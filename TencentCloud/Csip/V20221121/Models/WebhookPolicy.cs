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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Policy ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Policy name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Enabled status<br>Enumeration values:<br>ON: enable<br>OFF: disable</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Notification item list (module + submodule + severity + handling status)</p>
        /// </summary>
        [JsonProperty("NotifyItems")]
        public WebhookNotifyItem[] NotifyItems{ get; set; }

        /// <summary>
        /// <p>Account range of members to receive</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Notification asset scope</p>
        /// </summary>
        [JsonProperty("AssetScope")]
        public WebhookAssetScope AssetScope{ get; set; }

        /// <summary>
        /// <p>Accept format<br>Enumeration values:<br>TEXT: text format<br>JSON: JSON format</p>
        /// </summary>
        [JsonProperty("ReceiveFormat")]
        public string ReceiveFormat{ get; set; }

        /// <summary>
        /// <p>Push language<br>Enumeration values:<br>zh: Chinese<br>en: English</p>
        /// </summary>
        [JsonProperty("MsgLanguage")]
        public string MsgLanguage{ get; set; }

        /// <summary>
        /// <p>Custom passthrough field list. It is an empty array when turned off.</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public WebhookCustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>Receiving robot ID list</p>
        /// </summary>
        [JsonProperty("ReceiverIDList")]
        public long?[] ReceiverIDList{ get; set; }

        /// <summary>
        /// <p>Simplify info for the receiving robot (for list row display)</p>
        /// </summary>
        [JsonProperty("ReceiverList")]
        public WebhookReceiverBrief[] ReceiverList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "NotifyItems.", this.NotifyItems);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "AssetScope.", this.AssetScope);
            this.SetParamSimple(map, prefix + "ReceiveFormat", this.ReceiveFormat);
            this.SetParamSimple(map, prefix + "MsgLanguage", this.MsgLanguage);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArraySimple(map, prefix + "ReceiverIDList.", this.ReceiverIDList);
            this.SetParamArrayObj(map, prefix + "ReceiverList.", this.ReceiverList);
        }
    }
}

