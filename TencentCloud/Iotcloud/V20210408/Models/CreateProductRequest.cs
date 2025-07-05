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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProductRequest : AbstractModel
    {
        
        /// <summary>
        /// Product name, which cannot be same as that of an existing product. Naming rule: [a-zA-Z0-9:_-]{1,32}.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Product properties
        /// </summary>
        [JsonProperty("ProductProperties")]
        public ProductProperties ProductProperties{ get; set; }

        /// <summary>
        /// Skey, which is required to create a CLAA product.
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamObj(map, prefix + "ProductProperties.", this.ProductProperties);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
        }
    }
}

