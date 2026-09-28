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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteHealthCheckTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Health check template ID list. The ID format is `hct-` followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("HealthCheckTemplateIds")]
        public string[] HealthCheckTemplateIds{ get; set; }

        /// <summary>
        /// Whether to preview this request.
        /// - **false** (default): Send a normal request to directly delete the template.
        /// - **true**: Send a preview request to check whether the parameters, format, and service limits of the template to delete meet the requirements.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HealthCheckTemplateIds.", this.HealthCheckTemplateIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

