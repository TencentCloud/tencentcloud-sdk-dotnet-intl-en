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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UseDefaultRepoParameters : AbstractModel
    {
        
        /// <summary>
        /// TCR Enterprise instance name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnterpriseInstanceName")]
        public string EnterpriseInstanceName{ get; set; }

        /// <summary>
        /// TCR Enterprise billing mode. `0`: Pay-as-you-go 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnterpriseInstanceChargeType")]
        public long? EnterpriseInstanceChargeType{ get; set; }

        /// <summary>
        /// Edition of the TCR Enterprise. Values: `basic`, `standard`, `premium` (Advanced edition)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnterpriseInstanceType")]
        public string EnterpriseInstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnterpriseInstanceName", this.EnterpriseInstanceName);
            this.SetParamSimple(map, prefix + "EnterpriseInstanceChargeType", this.EnterpriseInstanceChargeType);
            this.SetParamSimple(map, prefix + "EnterpriseInstanceType", this.EnterpriseInstanceType);
        }
    }
}

