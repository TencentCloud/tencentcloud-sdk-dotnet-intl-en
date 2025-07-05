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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceTemplate : AbstractModel
    {
        
        /// <summary>
        /// Protocol port instance ID, such as `ppm-f5n1f8da`.
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// Template name.
        /// </summary>
        [JsonProperty("ServiceTemplateName")]
        public string ServiceTemplateName{ get; set; }

        /// <summary>
        /// Protocol port information.
        /// </summary>
        [JsonProperty("ServiceSet")]
        public string[] ServiceSet{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Protocol port template information with remarks
        /// </summary>
        [JsonProperty("ServiceExtraSet")]
        public ServicesInfo[] ServiceExtraSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "ServiceTemplateName", this.ServiceTemplateName);
            this.SetParamArraySimple(map, prefix + "ServiceSet.", this.ServiceSet);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "ServiceExtraSet.", this.ServiceExtraSet);
        }
    }
}

