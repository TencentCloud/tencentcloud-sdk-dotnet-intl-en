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

    public class SendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sender'S email address. when not using an alias, enter the sender's email address directly, for example: noreply@mail.qcloud.com. to enter a sender alias, follow this format (note that a space must separate the alias and email address): alias+space+<email address>. the alias cannot contain a colon (:).
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Recipient email address, supports up to 50 recipients in mass sending. note: the email content displays all recipient addresses. for non-mass sending, call the API multiple times to send.
        /// </summary>
        [JsonProperty("Destination")]
        public string[] Destination{ get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// The "reply" email address of the mail. can be filled with an email address where you can receive mail, which can be a personal mailbox. if left empty, the recipient's reply mail will fail to send.
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// Cc recipient email address, supports up to 20 carbon copies.
        /// </summary>
        [JsonProperty("Cc")]
        public string[] Cc{ get; set; }

        /// <summary>
        /// Bcc email address, supports up to 20 carbon copies. Bcc and Destination must be unique.
        /// </summary>
        [JsonProperty("Bcc")]
        public string[] Bcc{ get; set; }

        /// <summary>
        /// Use template for sending and fill in related parameters.
        /// <dx-alert infotype="notice" title="note">this field must be specified if you have not applied for special configuration.</dx-alert>.
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// This parameter has been deprecated.
        /// <dx-alert infotype="notice" title="description"> only customers who have applied for special configuration in the past need to use this. if you have not applied for special configuration, this field does not exist.</dx-alert>.
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// When sending an attachment, fill in the related parameters. the tencent cloud API request supports a maximum of 8M request packet. the attachment content transits Base64 and is expected to expand by 1.5 times. you should control the total size of all attachments within 4M. the API will return an error if the overall request exceeds 8M.
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// Unsubscription link options 0: do not add unsubscription link 1: english 2: simplified chinese 3: traditional chinese 4: spanish 5: french 6: german 7: japanese 8: korean 9: arabic 10: thai.
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// Mail trigger type. 0: non-trigger class, default type, select this type for marketing emails and non-instant emails. 1: trigger class, instant delivery emails such as captcha-intl. if the mail exceeds a certain size, the system will automatically select the non-trigger class channel.
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Message-Id field in the smtp header.
        /// </summary>
        [JsonProperty("SmtpMessageId")]
        public string SmtpMessageId{ get; set; }

        /// <summary>
        /// Other fields that can be set in the smtp header.
        /// </summary>
        [JsonProperty("SmtpHeaders")]
        public string SmtpHeaders{ get; set; }

        /// <summary>
        /// from field in the smtp header. the domain name should be consistent with FromEmailAddress.
        /// </summary>
        [JsonProperty("HeaderFrom")]
        public string HeaderFrom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamArraySimple(map, prefix + "Destination.", this.Destination);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "ReplyToAddresses", this.ReplyToAddresses);
            this.SetParamArraySimple(map, prefix + "Cc.", this.Cc);
            this.SetParamArraySimple(map, prefix + "Bcc.", this.Bcc);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "Simple.", this.Simple);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamSimple(map, prefix + "Unsubscribe", this.Unsubscribe);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "SmtpMessageId", this.SmtpMessageId);
            this.SetParamSimple(map, prefix + "SmtpHeaders", this.SmtpHeaders);
            this.SetParamSimple(map, prefix + "HeaderFrom", this.HeaderFrom);
        }
    }
}

