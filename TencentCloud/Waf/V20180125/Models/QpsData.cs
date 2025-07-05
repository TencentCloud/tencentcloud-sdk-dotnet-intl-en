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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QpsData : AbstractModel
    {
        
        /// <summary>
        /// Elastic QPS Default Value
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ElasticBillingDefault")]
        public ulong? ElasticBillingDefault{ get; set; }

        /// <summary>
        /// Elastic QPS Minimum Value
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ElasticBillingMin")]
        public ulong? ElasticBillingMin{ get; set; }

        /// <summary>
        /// Maximum Elastic QPS
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ElasticBillingMax")]
        public ulong? ElasticBillingMax{ get; set; }

        /// <summary>
        /// Maximum QPS for Business Expansion Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QPSExtendMax")]
        public ulong? QPSExtendMax{ get; set; }

        /// <summary>
        /// Maximum QPS for Overseas Business Expansion Package
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QPSExtendIntlMax")]
        public ulong? QPSExtendIntlMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ElasticBillingDefault", this.ElasticBillingDefault);
            this.SetParamSimple(map, prefix + "ElasticBillingMin", this.ElasticBillingMin);
            this.SetParamSimple(map, prefix + "ElasticBillingMax", this.ElasticBillingMax);
            this.SetParamSimple(map, prefix + "QPSExtendMax", this.QPSExtendMax);
            this.SetParamSimple(map, prefix + "QPSExtendIntlMax", this.QPSExtendIntlMax);
        }
    }
}

