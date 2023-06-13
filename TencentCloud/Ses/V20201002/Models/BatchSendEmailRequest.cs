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

    public class BatchSendEmailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sender address. Enter a sender address such as `noreply@mail.qcloud.com`. To display the sender name, enter the address in the following format:
        /// sender &lt;email address&gt;. For example:
        /// Tencent Cloud team &lt;noreply@mail.qcloud.com&gt;
        /// </summary>
        [JsonProperty("FromEmailAddress")]
        public string FromEmailAddress{ get; set; }

        /// <summary>
        /// Recipient group ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// Task type. `1`: immediate; `2`: scheduled; `3`: recurring
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// Reply-to address. You can enter a valid personal email address that can receive emails. If this parameter is left empty, reply emails will fail to be sent.
        /// </summary>
        [JsonProperty("ReplyToAddresses")]
        public string ReplyToAddresses{ get; set; }

        /// <summary>
        /// Template when emails are sent using a template
        /// </summary>
        [JsonProperty("Template")]
        public Template Template{ get; set; }

        /// <summary>
        /// Disused
        /// </summary>
        [JsonProperty("Simple")]
        public Simple Simple{ get; set; }

        /// <summary>
        /// Attachment parameters to set when you need to send attachments. This parameter is currently unavailable.
        /// </summary>
        [JsonProperty("Attachments")]
        public Attachment[] Attachments{ get; set; }

        /// <summary>
        /// Parameter required for a recurring sending task
        /// </summary>
        [JsonProperty("CycleParam")]
        public CycleEmailParam CycleParam{ get; set; }

        /// <summary>
        /// Parameter required for a scheduled sending task
        /// </summary>
        [JsonProperty("TimedParam")]
        public TimedEmailParam TimedParam{ get; set; }

        /// <summary>
        /// Unsubscribe link option. `0`: Do not add unsubscribe link; `1`: English `2`: Simplified Chinese; `3`: Traditional Chinese; `4`: Spanish; `5`: French; `6`: German; `7`: Japanese; `8`: Korean; `9`: Arabic; `10`: Thai
        /// </summary>
        [JsonProperty("Unsubscribe")]
        public string Unsubscribe{ get; set; }

        /// <summary>
        /// Whether to add an ad tag. `0`: Add no tag; `1`: Add before the subject; `2`: Add after the subject.
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

