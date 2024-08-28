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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebHookPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("Events")]
        public WebHookEventKv[] Events{ get; set; }

        /// <summary>
        /// Host range
        /// </summary>
        [JsonProperty("HostLabels")]
        public WebHookHostLabel[] HostLabels{ get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("Receivers")]
        public WebHookReceiver[] Receivers{ get; set; }

        /// <summary>
        /// Format. 0: text; 1: JSON.
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// Custom passthrough field
        /// </summary>
        [JsonProperty("CustomFields")]
        public WebHookCustomField[] CustomFields{ get; set; }

        /// <summary>
        /// Enable/Disable [1-Disable, 0-Enable]
        /// </summary>
        [JsonProperty("IsDisabled")]
        public long? IsDisabled{ get; set; }

        /// <summary>
        /// Host list
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExcludedQuuids")]
        public string[] ExcludedQuuids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamArrayObj(map, prefix + "HostLabels.", this.HostLabels);
            this.SetParamArrayObj(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludedQuuids.", this.ExcludedQuuids);
        }
    }
}

