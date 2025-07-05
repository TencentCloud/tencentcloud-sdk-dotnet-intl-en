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

    public class PortViewPortRisk : AbstractModel
    {
        
        /// <summary>
        /// Affected assets
        /// </summary>
        [JsonProperty("NoHandleCount")]
        public long? NoHandleCount{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Network protocol
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Components
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Last detected 
        /// </summary>
        [JsonProperty("RecentTime")]
        public string RecentTime{ get; set; }

        /// <summary>
        /// First detected
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Suggested action. `0`: Keep as it is; `1`: Block access requests; `2`: Block the port
        /// </summary>
        [JsonProperty("Suggestion")]
        public ulong? Suggestion{ get; set; }

        /// <summary>
        /// Status of the risk. `0`: Not handled, `1`: Handled; `2`: Ignored
        /// </summary>
        [JsonProperty("AffectAssetCount")]
        public string AffectAssetCount{ get; set; }

        /// <summary>
        /// Unique ID of the asset
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Asset sub-category
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// Data entry key
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// User AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User name.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// User `uin`
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Service
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoHandleCount", this.NoHandleCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RecentTime", this.RecentTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "AffectAssetCount", this.AffectAssetCount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Service", this.Service);
        }
    }
}

