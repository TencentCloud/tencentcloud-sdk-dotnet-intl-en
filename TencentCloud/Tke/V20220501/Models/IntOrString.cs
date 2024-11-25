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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntOrString : AbstractModel
    {
        
        /// <summary>
        /// Numerical type, 0: int, 1: string
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Integer
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IntVal")]
        public long? IntVal{ get; set; }

        /// <summary>
        /// String
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StrVal")]
        public string StrVal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IntVal", this.IntVal);
            this.SetParamSimple(map, prefix + "StrVal", this.StrVal);
        }
    }
}

