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

    public class BatchSendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sender'S email address. please fill in the sender's email address, such as noreply@mail.qcloud.com. if you need to fill in the sender's description, please follow.
        /// Sender &lt;email address&gt; via fill in, such as:.
        /// Tencent cloud team &lt;noreply@mail.qcloud.com&gt;.
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Recipient list ID.
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// Email subject.
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Task type 1: send now 2: scheduled sending 3: cycle (frequency) sending.
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// The "reply" email address of the mail. can be filled with an email address you can receive mail from, can be a personal mailbox. if left empty, the recipient's reply mail will fail to send.
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// When using a template to send, fill in the related parameters of the template.
        /// <Dx-Alert infotype="notice" title="note">this field must be specified if you have not applied for special configuration.</dx-alert>.
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// Abandoned<Dx-Alert infotype="notice" title="description">only customers who historically applied for special configuration require the use of it. if you have not applied for special configuration, this field does not exist.</dx-alert>.
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// Send attachment when required. fill in related parameters (not supported).
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// Required parameter for sending tasks periodically.
        /// </summary>
        [JsonProperty("CycleParam")]
        public CycleEmailParam CycleParam{ get; set; }

        /// <summary>
        /// Required parameter for scheduled task assignment.
        /// </summary>
        [JsonProperty("TimedParam")]
        public TimedEmailParam TimedParam{ get; set; }

        /// <summary>
        /// Unsubscription link options 0: do not add 1: english 2: simplified chinese 3: traditional chinese 4: spanish 5: french 6: german 7: japanese 8: korean 9: arabic 10: thai.
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// Whether to add an ad flag. valid values: 0 (do not add), 1 (add to the previous subject), 2 (add to the following subject).
        /// </summary>
        [JsonProperty("ADLocation")]
        public ulong? ADLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromEmailAddress", this.FromEmailAddress);
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ReplyToAddresses", this.ReplyToAddresses);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "Simple.", this.Simple);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamObj(map, prefix + "CycleParam.", this.CycleParam);
            this.SetParamObj(map, prefix + "TimedParam.", this.TimedParam);
            this.SetParamSimple(map, prefix + "Unsubscribe", this.Unsubscribe);
            this.SetParamSimple(map, prefix + "ADLocation", this.ADLocation);
        }
    }
}

