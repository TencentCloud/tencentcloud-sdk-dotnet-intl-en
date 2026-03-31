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
        /// <p>Sender's email address. If no alias is used, enter the sender's email address directly, for example: noreply@mail.qcloud.com. To use a sender alias, follow this format (note that a space must be used between the alias and the email address): alias+space+&lt;email address&gt;. The alias cannot contain a colon (:).</p>
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// <p>Email Subject</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// <p>Recipient email address, supports up to 50 recipients in mass sending. Note: The email content displays all recipient addresses. For non-mass sending, call the API multiple times to send.<br>At least one of the three parameters Destination/Cc/Bcc must exist.</p>
        /// </summary>
        [JsonProperty("Destination")]
        public string[] Destination{ get; set; }

        /// <summary>
        /// <p>The "reply" email address of the mail. Can be filled with a mailbox address where you can receive emails, which can be a personal mailbox. If left empty, the recipient's reply mail will fail to send.</p>
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// <p>Email address of CC recipients, supports up to 20 carbon copies.</p>
        /// </summary>
        [JsonProperty("Cc")]
        public string[] Cc{ get; set; }

        /// <summary>
        /// <p>Bcc email address, supports up to 20 carbon copies. Bcc and Destination must be unique.</p>
        /// </summary>
        [JsonProperty("Bcc")]
        public string[] Bcc{ get; set; }

        /// <summary>
        /// <p>Fill in the template parameters when sending with a template.</p><blockquote class="rno-document-tips rno-document-tips-notice">    <div class="rno-document-tips-body">        <i class="rno-document-tip-icon"></i>        <div class="rno-document-tip-title">Note</div>        <div class="rno-document-tip-desc"><p>This field must be specified if you have not applied for special configuration</p></div>    </div></blockquote>
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// <p>Abandoned</p><blockquote class="rno-document-tips rno-document-tips-notice">    <div class="rno-document-tips-body">        <i class="rno-document-tip-icon"></i>        <div class="rno-document-tip-title">Description</div>        <div class="rno-document-tip-desc"><p>Only customers who historically applied for special configuration require the use of this. If you have not applied for special configuration, this field does not exist.</p></div>    </div></blockquote>
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// <p>To send an attachment, fill in the relevant parameters. The Tencent Cloud API request supports a maximum of 8M request packet. The attachment content is expected to expand by 1.5 times after Base64 encoding. The total size of all attachments should not exceed 4M. The API will return an error if the overall request exceeds 8M.</p>
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// Unsubscription link options 0: do not add unsubscription link 1: english 2: simplified chinese 3: traditional chinese 4: spanish 5: french 6: german 7: japanese 8: korean 9: arabic 10: thai 11: indonesian.
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// <p>Mail trigger type 0: Non-trigger class, default type, select this type for marketing email, non-instant mail. 1: Trigger class, instant delivery mail such as verification code. If the mail exceeds a certain size, the system will automatically select a non-trigger type channel.</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// <p>Message-Id field in the smtp header</p>
        /// </summary>
        [JsonProperty("SmtpMessageId")]
        public string SmtpMessageId{ get; set; }

        /// <summary>
        /// <p>Other fields that can be set in the smtp header</p>
        /// </summary>
        [JsonProperty("SmtpHeaders")]
        public string SmtpHeaders{ get; set; }

        /// <summary>
        /// <p>The from field in the smtp header. The domain name should be consistent with the FromEmailAddress.</p>
        /// </summary>
        [JsonProperty("HeaderFrom")]
        public string HeaderFrom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamArraySimple(map, prefix + "Destination.", this.Destination);
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

