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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Specified query for product version and architecture.</p><ul><li>6: Redis 4.0 standard architecture;</li><li>7: Redis 4.0 cluster architecture;</li><li>8: Redis 5.0 standard architecture;</li><li>9: Redis 5.0 cluster architecture;</li><li>15: Redis 6.2 standard architecture;</li><li>16: Redis 6.2 cluster architecture;</li><li>17: Redis 7.0 standard architecture;</li><li>18: Redis 7.0 cluster architecture;</li><li>19: ValKey 8.0 standard architecture;</li><li>20: ValKey 8.0 cluster architecture.</li></ul>
        /// </summary>
        [JsonProperty("ProductTypes")]
        public long?[] ProductTypes{ get; set; }

        /// <summary>
        /// <p>Specify the parameter template name for the query.</p><ul><li>Data type: string array, with a maximum length limit of 50.</li><li>Method for obtaining: Copy the Template name of a custom template or system default template on the <a href="https://console.cloud.tencent.com/redis/templates">parameter template page in the Redis console</a>.</li></ul>
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// <p>Parameter template ID specified for query.</p><ul><li>Data type: string array, with a maximum length limit of 50.</li><li>Method for obtaining: Copy the template ID of a custom template or system default template on the <a href="https://console.cloud.tencent.com/redis/templates">parameter template page in the Redis console</a>.</li></ul>
        /// </summary>
        [JsonProperty("TemplateIds")]
        public string[] TemplateIds{ get; set; }

        /// <summary>
        /// <p>Specify the pagination size of the query result, which is the number of records returned per page.</p><ul><li>Value ranges from 0–200.</li><li>Default value: 200.</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Pagination offset, used to specify the starting position of the query result.</p><ul><li>Value: Must be an integral multiple of Limit. Default value is 0.</li><li>Calculation formula: offset=limit*(page number-1).</li></ul>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProductTypes.", this.ProductTypes);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

