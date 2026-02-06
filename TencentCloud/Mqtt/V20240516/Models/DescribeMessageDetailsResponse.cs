/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMessageDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// Message body.
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// Describes the user-customized attribute.
        /// </summary>
        [JsonProperty("UserProperties")]
        public UserProperty[] UserProperties{ get; set; }

        /// <summary>
        /// Specifies the message storage time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("StoreTimestamp")]
        public long? StoreTimestamp{ get; set; }

        /// <summary>
        /// Message ID.
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// Producer address.
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// Specifies the source topic.
        /// </summary>
        [JsonProperty("OriginTopic")]
        public string OriginTopic{ get; set; }

        /// <summary>
        /// Content type (MQTT5).
        /// Indicates the content type of the message payload using standard MIME type format. helps the receiver correctly parse and process the message content.
        /// Specifies the example.
        /// application/json: indicates the payload is data in json format.
        /// Text/Plain: indicates the payload is plain text.
        /// application/octet-stream: indicates the payload is binary data.
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// Payload format indicator (MQTT5).
        /// Indicates the payload format, which is a boolean value. 0 means an unspecified format (binary), and 1 means a UTF-8 encoded string.
        /// Specifies the example.
        /// Valid values: 0 indicates the payload is binary data, such as images or audio.
        /// Valid value 1: when the payload is UTF-8 encoded text, such as JSON string or XML.
        /// </summary>
        [JsonProperty("PayloadFormatIndicator")]
        public long? PayloadFormatIndicator{ get; set; }

        /// <summary>
        /// Message expiration interval (MQTT5).
        /// Specifies the validity time (in seconds) of the specified message before it is discarded. if the message fails to reach the MQTT server before expiration, it will be discarded.
        /// Specifies the example.
        /// The value 60 indicates that the message is valid within 60 seconds after release. unreached messages will be dropped after expiry.
        /// A value of 0 indicates the message never expires and remains permanently valid until received or the session ends.
        /// </summary>
        [JsonProperty("MessageExpiryInterval")]
        public long? MessageExpiryInterval{ get; set; }

        /// <summary>
        /// Response topic (MQTT5).
        /// Specifies a topic for the response message in request-response mode. the sender can specify which topic the recipient should send the response to.
        /// Specifies the example.
        /// Sender publishes a request to the topic devices/device1/commands and sets ResponseTopic to devices/device1/responses.
        /// Specifies the topic where the response is published after the recipient processes the request.
        /// </summary>
        [JsonProperty("ResponseTopic")]
        public string ResponseTopic{ get; set; }

        /// <summary>
        /// Associated data (MQTT5).
        /// Specifies the identifier used to associate a request and response, usually a byte array. in request-response mode, the sender sets this value, and the recipient includes the same value in the response so that the sender can identify the corresponding request.
        /// Specifies the example.
        /// The sender generates a unique ID (such as a byte[] of UUID) as CorrelationData and adds it to the request message.
        /// The recipient includes the same CorrelationData in the response message. the sender compares this value to match the response and the request.
        /// </summary>
        [JsonProperty("CorrelationData")]
        public string CorrelationData{ get; set; }

        /// <summary>
        /// Subscription identifier (MQTT5).
        /// Specifies the unique identifier assigned to the subscription, used to identify a specific subscription of the client. when sending a message to the client, the server can include this identifier to help with client identification of the corresponding subscription.
        /// Specifies the example.
        /// The client subscribes to the topic devices/+/temperature and sets SubscriptionIdentifier to 123.
        /// When the server sends a message of this topic to the client, the message will contain SubscriptionIdentifier: 123. the client can know which subscription the message is sent through based on this value.
        /// </summary>
        [JsonProperty("SubscriptionIdentifier")]
        public string SubscriptionIdentifier{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamArrayObj(map, prefix + "UserProperties.", this.UserProperties);
            this.SetParamSimple(map, prefix + "StoreTimestamp", this.StoreTimestamp);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "OriginTopic", this.OriginTopic);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "PayloadFormatIndicator", this.PayloadFormatIndicator);
            this.SetParamSimple(map, prefix + "MessageExpiryInterval", this.MessageExpiryInterval);
            this.SetParamSimple(map, prefix + "ResponseTopic", this.ResponseTopic);
            this.SetParamSimple(map, prefix + "CorrelationData", this.CorrelationData);
            this.SetParamSimple(map, prefix + "SubscriptionIdentifier", this.SubscriptionIdentifier);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

