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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKBRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Knowledge base type (0 not allowed. Parameter Value: 1=default knowledge base, 2=shared knowledge base)<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>KB_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KB_TYPE_DEFAULT</td><td>1</td><td>Default knowledge base</td></tr><tr><td>KB_TYPE_SHARED</td><td>2</td><td>Shared knowledge base</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("KbType")]
        public long? KbType{ get; set; }

        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Writable attribute</p>
        /// </summary>
        [JsonProperty("Spec")]
        public KBSpec Spec{ get; set; }

        /// <summary>
        /// <p>Share sub-type: 1=ordinary, 2=wechat official account<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>SHARED_KB_SUB_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SHARED_KB_SUB_TYPE_NORMAL</td><td>1</td><td>Ordinary</td></tr><tr><td>SHARED_KB_SUB_TYPE_PUBLIC_ACCOUNT</td><td>2</td><td>WeChat Official Account</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("SharedSubType")]
        public long? SharedSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbType", this.KbType);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamObj(map, prefix + "Spec.", this.Spec);
            this.SetParamSimple(map, prefix + "SharedSubType", this.SharedSubType);
        }
    }
}

