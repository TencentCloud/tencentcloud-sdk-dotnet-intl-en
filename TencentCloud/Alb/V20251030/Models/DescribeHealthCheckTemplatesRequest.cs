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

    public class DescribeHealthCheckTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Filter. Query health check templates by specifying filter criteria. Supported:</p><ul><li>Name is <strong>HealthCheckTemplateName</strong>. Filter health check templates by name. <strong>Values</strong> is a template name list.</li><li>Name is <strong>HealthCheckProtocol</strong>. Filter health check templates by health check protocol. <strong>Values</strong> is a protocol list.</li><li>Filter by tag.</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Health check template ID list. The ID format is hct- followed by alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("HealthCheckTemplateIds")]
        public string[] HealthCheckTemplateIds{ get; set; }

        /// <summary>
        /// <p>The number of returned lists. Default value: 20. Maximum value: 100.</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public string MaxResults{ get; set; }

        /// <summary>
        /// <p>Token for the next query. Not required for the first query or when there is no next query.<br>If there is a next query, the value is the NextToken returned from the last API call.</p>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "HealthCheckTemplateIds.", this.HealthCheckTemplateIds);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

