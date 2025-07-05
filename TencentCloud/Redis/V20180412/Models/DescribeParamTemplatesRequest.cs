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
        /// Product type array.
        /// - 2: Redis 2.8 Memory Edition (standard architecture).
        /// - 3: CKV 3.2 Memory Edition (standard architecture).
        /// - 4: CKV 3.2 Memory Edition (cluster architecture).
        /// - 6: Redis 4.0 Memory Edition (standard architecture).
        /// - 7: Redis 4.0 Memory Edition (cluster architecture).
        /// - 8: Redis 5.0 Memory Edition (standard architecture).
        /// - 9: Redis 5.0 Memory Edition (cluster architecture).
        /// - 15: Redis 6.2 Memory Edition (standard architecture).
        /// - 16: Redis 6.2 Memory Edition (cluster architecture).
        /// - 17: Redis 7.0 Memory Edition (standard architecture).
        /// - 18: Redis 7.0 Memory Edition (cluster architecture).
        /// </summary>
        [JsonProperty("ProductTypes")]
        public long?[] ProductTypes{ get; set; }

        /// <summary>
        /// Template name array, with the maximum array length of 50.
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// Template ID array, with the maximum array length of 50.
        /// </summary>
        [JsonProperty("TemplateIds")]
        public string[] TemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProductTypes.", this.ProductTypes);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
        }
    }
}

