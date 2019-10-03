// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Newtonsoft.Json.Linq;

namespace NuGet.Protocol.Plugins
{
    internal class ExceptionLogMessage : PluginLogMessage
    {
        private string _requestId;
        private MessageMethod _method;
        private MessageType _type;
        private string _exceptionType;
        private string _message;
        private string _stackTrace;
        private TaskState _state;

        public ExceptionLogMessage(DateTimeOffset now, string requestId, MessageMethod method, MessageType type, string exceptionType, string message, string stackTrace, TaskState state)
                        : base(now)
        {
            _requestId = requestId;
            _method = method;
            _type = type;
            _exceptionType = exceptionType;
            _message = message;
            _stackTrace = stackTrace;
            _state = state;
        }


        public override string ToString()
        {
            var message = new JObject(
                new JProperty("request ID", _requestId),
                new JProperty("method", _method),
                new JProperty("type", _type),
                new JProperty("exception type", _exceptionType),
                new JProperty("exception message", _message),
                new JProperty("stackTrace", _stackTrace),
                new JProperty("state", _state));

            return ToString("exception", message);
        }
    }
}
