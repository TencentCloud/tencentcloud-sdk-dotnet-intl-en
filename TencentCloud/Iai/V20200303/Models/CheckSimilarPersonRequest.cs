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

    public class CheckSimilarPersonRequest : AbstractModel
    {
        
        /// <summary>
        /// List of groups to be checked. 
        /// There can be up to 2 million persons in one group and up to 10 groups.
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// Control over the strictness of duplicate person check.
        /// 1: archive sorting with high strictness, which can eliminate more duplicate identities but leads to higher false elimination rate for non-duplicate identities.
        /// 2: archive sorting with low strictness, which leads to lower false elimination rate for non-duplicate identities and lower elimination rate for duplicate identities.
        /// </summary>
        [JsonProperty("UniquePersonControl")]
        public long? UniquePersonControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "UniquePersonControl", this.UniquePersonControl);
        }
    }
}

