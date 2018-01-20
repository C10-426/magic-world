

using System;

public class EventException : Exception {

    public EventException(string detailMessage) : base(detailMessage) {
    }

    public EventException(string detailMessage, Exception innerException) : base(detailMessage, innerException) {
    }

}