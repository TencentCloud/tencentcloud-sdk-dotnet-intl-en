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

    public class CreateNewL7RulesUploadRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type (`bgpip`: Anti-DDoS Advanced).
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Resource ID list.
        /// </summary>
        [JsonProperty("IdList")]
        public string[] IdList{ get; set; }

        /// <summary>
        /// Resource IP address list.
        /// </summary>
        [JsonProperty("VipList")]
        public string[] VipList{ get; set; }

        /// <summary>
        /// Rule list.
        /// </summary>
        [JsonProperty("Rules")]
        public L7RuleEntry[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
            this.SetParamArraySimple(map, prefix + "VipList.", this.VipList);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

