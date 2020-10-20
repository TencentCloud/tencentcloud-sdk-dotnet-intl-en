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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Eye : AbstractModel
    {
        
        /// <summary>
        /// Whether glasses are worn.
        /// The `Type` values of the `AttributeItem` include: 0: no glasses; 1: general glasses; 2: sunglasses.
        /// </summary>
        [JsonProperty("Glass")]
        public AttributeItem Glass{ get; set; }

        /// <summary>
        /// Whether the eyes are open.
        /// The `Type` values of the `AttributeItem` include: 0: open; 1: closed.
        /// </summary>
        [JsonProperty("EyeOpen")]
        public AttributeItem EyeOpen{ get; set; }

        /// <summary>
        /// Whether the person has double eyelids.
        /// The `Type` values of the `AttributeItem` include: 0: no; 1: yes.
        /// </summary>
        [JsonProperty("EyelidType")]
        public AttributeItem EyelidType{ get; set; }

        /// <summary>
        /// Eye size.
        /// The `Type` values of the `AttributeItem` include: 0: small eyes; 1: general eyes; 2: big eyes.
        /// </summary>
        [JsonProperty("EyeSize")]
        public AttributeItem EyeSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Glass.", this.Glass);
            this.SetParamObj(map, prefix + "EyeOpen.", this.EyeOpen);
            this.SetParamObj(map, prefix + "EyelidType.", this.EyelidType);
            this.SetParamObj(map, prefix + "EyeSize.", this.EyeSize);
        }
    }
}

