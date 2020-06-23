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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchedulingDomain : AbstractModel
    {
        
        /// <summary>
        /// Scheduling domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// List of BGP IPs
        /// </summary>
        [JsonProperty("BGPIpList")]
        public string[] BGPIpList{ get; set; }

        /// <summary>
        /// List of CTCC IPs
        /// </summary>
        [JsonProperty("CTCCIpList")]
        public string[] CTCCIpList{ get; set; }

        /// <summary>
        /// List of CUCC IPs
        /// </summary>
        [JsonProperty("CUCCIpList")]
        public string[] CUCCIpList{ get; set; }

        /// <summary>
        /// List of CMCC IPs
        /// </summary>
        [JsonProperty("CMCCIpList")]
        public string[] CMCCIpList{ get; set; }

        /// <summary>
        /// List of IPs outside Mainland China
        /// </summary>
        [JsonProperty("OverseaIpList")]
        public string[] OverseaIpList{ get; set; }

        /// <summary>
        /// Scheduling method. It only supports `priority` now.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "BGPIpList.", this.BGPIpList);
            this.SetParamArraySimple(map, prefix + "CTCCIpList.", this.CTCCIpList);
            this.SetParamArraySimple(map, prefix + "CUCCIpList.", this.CUCCIpList);
            this.SetParamArraySimple(map, prefix + "CMCCIpList.", this.CMCCIpList);
            this.SetParamArraySimple(map, prefix + "OverseaIpList.", this.OverseaIpList);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

