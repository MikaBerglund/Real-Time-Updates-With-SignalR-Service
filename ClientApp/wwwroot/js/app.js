
var hbConnection = new signalR.HubConnectionBuilder().withUrl("/events/heartbeat").build();
var msgConnection = new signalR.HubConnectionBuilder().withUrl("/events/message").build();

var setInnerText = (id, text) => {
    document.getElementById(id).innerText = text;
};

hbConnection.start()
    .then(() => {
        setInnerText("heartbeat-status", "OK");
    })
    .catch(err => {
        console.error("Error while starting heartbeat connection.", err);
        setInnerText("heartbeat-status", "Error");
    }
);
msgConnection.start()
    .then(() => {
        setInnerText("message-status", "OK");
    })
    .catch(err => {
        console.error("Error while starting message connection.", err);
        setInnerText("message-status", "Error");
    }
);

hbConnection.on("heartbeat", (name, msg) => {
    setInnerText("heartbeat", msg);
});

msgConnection.on("message", (name, msg) => {
    setInnerText("message", msg);
});