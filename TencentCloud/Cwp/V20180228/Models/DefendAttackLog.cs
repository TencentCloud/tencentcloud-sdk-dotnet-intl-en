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

    public class DefendAttackLog : AbstractModel
    {
        
        /// <summary>
        /// Log ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Source IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// Source port
        /// </summary>
        [JsonProperty("SrcPort")]
        public ulong? SrcPort{ get; set; }

        /// <summary>
        /// Attack method
        /// </summary>
        [JsonProperty("HttpMethod")]
        public string HttpMethod{ get; set; }

        /// <summary>
        /// Attack description
        /// </summary>
        [JsonProperty("HttpCgi")]
        public string HttpCgi{ get; set; }

        /// <summary>
        /// Attack parameter
        /// </summary>
        [JsonProperty("HttpParam")]
        public string HttpParam{ get; set; }

        /// <summary>
        /// Threat type
        /// </summary>
        [JsonProperty("VulType")]
        public string VulType{ get; set; }

        /// <summary>
        /// Attack time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Target server IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Target server name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Target IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// Target port
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// Attack content
        /// </summary>
        [JsonProperty("HttpContent")]
        public string HttpContent{ get; set; }

        /// <summary>
        /// Host Additional Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "SrcPort", this.SrcPort);
            this.SetParamSimple(map, prefix + "HttpMethod", this.HttpMethod);
            this.SetParamSimple(map, prefix + "HttpCgi", this.HttpCgi);
            this.SetParamSimple(map, prefix + "HttpParam", this.HttpParam);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "HttpContent", this.HttpContent);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

