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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CNAMEDetail : AbstractModel
    {
        
        /// <summary>
        /// Whether it is a fake site, with values:.
        /// <Li>0: non-fake site.</li>.
        /// <Li>1: fake site.</li>.
        /// </summary>
        [JsonProperty("IsFake")]
        public long? IsFake{ get; set; }

        /// <summary>
        /// Ownership verification information. for details, refer to [site/domain ownership verification](https://www.tencentcloud.comom/document/product/1552/70789?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsFake", this.IsFake);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
        }
    }
}

