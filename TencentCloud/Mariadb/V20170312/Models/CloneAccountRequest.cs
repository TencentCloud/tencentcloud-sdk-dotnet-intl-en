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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Source user account name
        /// </summary>
        [JsonProperty("SrcUser")]
        public string SrcUser{ get; set; }

        /// <summary>
        /// Source user host
        /// </summary>
        [JsonProperty("SrcHost")]
        public string SrcHost{ get; set; }

        /// <summary>
        /// Target user account name
        /// </summary>
        [JsonProperty("DstUser")]
        public string DstUser{ get; set; }

        /// <summary>
        /// Target user host
        /// </summary>
        [JsonProperty("DstHost")]
        public string DstHost{ get; set; }

        /// <summary>
        /// Target account description
        /// </summary>
        [JsonProperty("DstDesc")]
        public string DstDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SrcUser", this.SrcUser);
            this.SetParamSimple(map, prefix + "SrcHost", this.SrcHost);
            this.SetParamSimple(map, prefix + "DstUser", this.DstUser);
            this.SetParamSimple(map, prefix + "DstHost", this.DstHost);
            this.SetParamSimple(map, prefix + "DstDesc", this.DstDesc);
        }
    }
}

