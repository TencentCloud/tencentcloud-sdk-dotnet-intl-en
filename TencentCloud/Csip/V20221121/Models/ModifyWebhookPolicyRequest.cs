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

    public class ModifyWebhookPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Policy Name<br>Input parameter limit: 1-20 characters, tenant-unique</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Enable status<br>Enumeration values:<br>ON: Enabled<br>OFF: Disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>List of notification items<br>Input parameter limit: at least 1 item. Module/SubModule must be a valid composite returned by DescribeWebhookNotifyItemTree</p>
        /// </summary>
        [JsonProperty("NotifyItems")]
        public WebhookNotifyItem[] NotifyItems{ get; set; }

        /// <summary>
        /// <p>Asset scope for notification</p>
        /// </summary>
        [JsonProperty("AssetScope")]
        public WebhookAssetScope AssetScope{ get; set; }

        /// <summary>
        /// <p>Accept format<br>Enumeration values:<br>TEXT: Text format<br>JSON: JSON format</p>
        /// </summary>
        [JsonProperty("ReceiveFormat")]
        public string ReceiveFormat{ get; set; }

        /// <summary>
        /// <p>Receiving robot ID list<br>Input limits: at least 1, up to 50</p>
        /// </summary>
        [JsonProperty("ReceiverIDList")]
        public long?[] ReceiverIDList{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Policy ID. More than 0 means modification; equal to 0 or not passed means adding new<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Push language<br>Enumeration values:<br>zh: Chinese<br>en: English<br>Default value: zh on the Chinese site and en on the international site</p>
        /// </summary>
        [JsonProperty("MsgLanguage")]
        public string MsgLanguage{ get; set; }

        /// <summary>
        /// <p>List of custom passthrough fields<br>Input limitation: Required when EnableCustomFields=true, up to 20</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public WebhookCustomField[] CustomFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "NotifyItems.", this.NotifyItems);
            this.SetParamObj(map, prefix + "AssetScope.", this.AssetScope);
            this.SetParamSimple(map, prefix + "ReceiveFormat", this.ReceiveFormat);
            this.SetParamArraySimple(map, prefix + "ReceiverIDList.", this.ReceiverIDList);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "MsgLanguage", this.MsgLanguage);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
        }
    }
}

