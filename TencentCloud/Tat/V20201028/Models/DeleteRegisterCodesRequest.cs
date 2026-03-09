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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRegisterCodesRequest : AbstractModel
    {
        
        /// <summary>
        /// Registration code ID list. limits the input registration code ID quantity to more than 0 and less than 100.
        /// 
        /// Call the [DescribeRegisterCodes](https://www.tencentcloud.comom/document/api/1340/96925?from_cn_redirect=1) api to query registration codes.
        /// </summary>
        [JsonProperty("RegisterCodeIds")]
        public string[] RegisterCodeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RegisterCodeIds.", this.RegisterCodeIds);
        }
    }
}

