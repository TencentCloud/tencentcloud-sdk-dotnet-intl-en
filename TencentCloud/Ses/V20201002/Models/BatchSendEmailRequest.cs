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
        /// <p>Sender's email address. Please fill in the sender's email address, for example: noreply@mail.qcloud.com. If you need to fill in the sender description, please enter it via<br>sender &lt;email address&gt;, for example:<br>Tencent Cloud team &lt;noreply@mail.qcloud.com&gt;</p>
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// <p>Recipient list ID</p>
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// <p>Email Subject</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// <p>Task type 1: Send now 2: Scheduled sending 3: Cycle (frequency) sending</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// <p>The "reply" email address of the mail. Can be filled with an email address you can receive mail, can be a personal mailbox. If left empty, the recipient's reply mail will fail to send.</p>
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// <p>Template-related parameters to fill in when sending with a template</p><blockquote class="rno-document-tips rno-document-tips-notice">    <div class="rno-document-tips-body">        <i class="rno-document-tip-icon"></i>        <div class="rno-document-tip-title">Note</div>        <div class="rno-document-tip-desc"><p>This field must be specified if you have not applied for special configuration</p></div>    </div></blockquote>
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// <p>Abandoned<blockquote class="rno-document-tips rno-document-tips-notice">    <div class="rno-document-tips-body">        <i class="rno-document-tip-icon"></i>        <div class="rno-document-tip-title">Description</div>        <div class="rno-document-tip-desc"><p>Only customers who historically applied for special configuration need to use this. If you have not applied for special configuration, this field does not exist.</p></div>    </div></blockquote></p>
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// <p>When you need to send an attachment, fill in the related parameters (not supported).</p>
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// <p>Required parameter for sending tasks periodically</p>
        /// </summary>
        [JsonProperty("CycleParam")]
        public CycleEmailParam CycleParam{ get; set; }

        /// <summary>
        /// <p>Required parameter of scheduled task assignment</p>
        /// </summary>
        [JsonProperty("TimedParam")]
        public TimedEmailParam TimedParam{ get; set; }

        /// <summary>
        /// Unsubscription link options 0: do not add 1: english 2: simplified chinese 3: traditional chinese 4: spanish 5: french 6: german 7: japanese 8: korean 9: arabic 10: thai. 11: indonesian.
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// <p>Whether to add an ad flag 0: do not add 1: add to the previous subject 2: add to the following subject</p>
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

