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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendEmailStatus : AbstractModel
    {
        
        /// <summary>
        /// The `MessageId` field returned by the `SendEmail` API
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        [JsonProperty("ToEmailAddress")]
        public string ToEmailAddress{ get; set; }

        /// <summary>
        /// Sender email address
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Tencent Cloud processing status
        /// 0: Successful.
        /// 1001: Internal system exception.
        /// 1002: Internal system exception.
        /// 1003: Internal system exception.
        /// 1003: Internal system exception.
        /// 1004: Email sending timed out.
        /// 1005: Internal system exception.
        /// 1006: You have sent too many emails to the same address in a short period.
        /// 1007: The email address is in the blocklist.
        /// 1008: The sender domain is rejected by the recipient.
        /// 1009: Internal system exception.
        /// 1010: The daily email sending limit is exceeded.
        /// 1011: You have no permission to send custom content. Use a template.
        /// 1013: The sender domain is unsubscribed from by the recipient.
        /// 2001: No results were found.
        /// 3007: The template ID is invalid or the template is unavailable.
        /// 3008: The sender domain is temporarily blocked by the recipient domain.
        /// 3009: You have no permission to use this template.
        /// 3010: The format of the `TemplateData` field is incorrect. 
        /// 3014: The email cannot be sent because the sender domain is not verified.
        /// 3020: The recipient email address is in the blocklist.
        /// 3024: Failed to precheck the email address format.
        /// 3030: Email sending is restricted temporarily due to a high bounce rate.
        /// 3033: The account has insufficient balance or overdue payment.
        /// </summary>
        [JsonProperty("SendStatus")]
        public long? SendStatus{ get; set; }

        /// <summary>
        /// Recipient processing status
        /// 0: Tencent Cloud has accepted the request and added it to the send queue.
        /// 1: The email is delivered successfully. `DeliverTime` indicates the time when the email is delivered successfully.
        /// 2: The email is discarded. `DeliverMessage` indicates the reason for discarding.
        /// 3: The recipient's ESP rejects the email, probably because the email address does not exist or due to other reasons.
        /// 8: The email is delayed by the ESP. `DeliverMessage` indicates the reason for delay.
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public long? DeliverStatus{ get; set; }

        /// <summary>
        /// Description of the recipient processing status
        /// </summary>
        [JsonProperty("DeliverMessage")]
        public string DeliverMessage{ get; set; }

        /// <summary>
        /// Timestamp when the request arrives at Tencent Cloud
        /// </summary>
        [JsonProperty("RequestTime")]
        public long? RequestTime{ get; set; }

        /// <summary>
        /// Timestamp when Tencent Cloud delivers the email
        /// </summary>
        [JsonProperty("DeliverTime")]
        public long? DeliverTime{ get; set; }

        /// <summary>
        /// Whether the recipient has opened the email
        /// </summary>
        [JsonProperty("UserOpened")]
        public bool? UserOpened{ get; set; }

        /// <summary>
        /// Whether the recipient has clicked the links in the email
        /// </summary>
        [JsonProperty("UserClicked")]
        public bool? UserClicked{ get; set; }

        /// <summary>
        /// Whether the recipient has unsubscribed from the email sent by the sender
        /// </summary>
        [JsonProperty("UserUnsubscribed")]
        public bool? UserUnsubscribed{ get; set; }

        /// <summary>
        /// Whether the recipient has reported the sender
        /// </summary>
        [JsonProperty("UserComplainted")]
        public bool? UserComplainted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "ToEmailAddress", this.ToEmailAddress);
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamSimple(map, prefix + "SendStatus", this.SendStatus);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamSimple(map, prefix + "DeliverMessage", this.DeliverMessage);
            this.SetParamSimple(map, prefix + "RequestTime", this.RequestTime);
            this.SetParamSimple(map, prefix + "DeliverTime", this.DeliverTime);
            this.SetParamSimple(map, prefix + "UserOpened", this.UserOpened);
            this.SetParamSimple(map, prefix + "UserClicked", this.UserClicked);
            this.SetParamSimple(map, prefix + "UserUnsubscribed", this.UserUnsubscribed);
            this.SetParamSimple(map, prefix + "UserComplainted", this.UserComplainted);
        }
    }
}

