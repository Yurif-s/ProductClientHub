﻿namespace ProductClientHub.Communication.Responses;

public class ResponseErrorsMessagesJson
{
    public List<string> Errors { get; private set; }

    public ResponseErrorsMessagesJson(string message)
    {
        Errors = [message];
    }

    public ResponseErrorsMessagesJson(List<string> messages)
    {
        Errors = messages;
    }
}
