/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sender address. Enter a sender address, for example, noreply@mail.qcloud.com.
        /// To display the sender name, enter the address in the following format: 
        /// Sender <email address>
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Recipient email addresses. You can send an email to up to 50 recipients at a time. Note: the email content will display all recipient addresses. To send one-to-one emails to several recipients, please call the API multiple times to send the emails.
        /// </summary>
        [JsonProperty("Destination")]
        public string[] Destination{ get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Reply-to address. You can enter a valid personal email address that can receive emails. If this field is left empty, reply emails will be sent to Tencent Cloud.
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// Template when sending emails using a template.
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// Email content when sending emails by calling the API.
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// Email attachments
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// Unsubscribe option. `1`: provides an unsubscribe link; `0`: does not provide an unsubscribe link
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// Email triggering type. `0` (default): non-trigger-based, suitable for marketing emails and non-immediate emails; `1`: trigger-based, suitable for immediate emails such as emails containing verification codes. If the size of an email exceeds a specified value, the system will automatically choose the non-trigger-based type.
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamArraySimple(map, prefix + "Destination.", this.Destination);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "ReplyToAddresses", this.ReplyToAddresses);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "Simple.", this.Simple);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamSimple(map, prefix + "Unsubscribe", this.Unsubscribe);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
        }
    }
}

