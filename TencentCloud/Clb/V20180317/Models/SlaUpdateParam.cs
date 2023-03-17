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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlaUpdateParam : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// This parameter is set to a fixed value of `SLA`, which specifies to upgrade to an LCU-supported instance of default specification.
        /// <ul><li>If you enable general LCU-supported instances, `SLA` corresponds to the Super Large 1 specification. General LCU-supported instances are in beta testing, [submit a ticket](https://intl.cloud.tencent.com/apply/p/hf45esx99lf?from_cn_redirect=1) for application.</li>
        /// <li>If you enable ultra-large LCU-supported instances, SLA corresponds to the Super Large 4 specification. Ultra-large LCU-supported instances are in beta testing, [submit a ticket](https://console.cloud.tencent.com/workorder/category) for application.</li></ul>
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
        }
    }
}

