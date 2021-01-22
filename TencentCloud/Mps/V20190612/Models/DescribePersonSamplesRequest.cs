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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePersonSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// Type of the material pulled. Valid values:
        /// <li>UserDefine: custom material library;</li>
        /// <li>Default: default material library.</li>
        /// 
        /// Default value: UserDefine (the materials of the custom material library are pulled.)
        /// Note: you can pull the default material library only using the material name or a combination of the material name and ID, and only one face image is returned.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Material ID. Array length limit: 100.
        /// </summary>
        [JsonProperty("PersonIds")]
        public string[] PersonIds{ get; set; }

        /// <summary>
        /// Material name. Array length limit: 20.
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// Material tag. Array length limit: 20.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Paging offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. Default value: 100. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "PersonIds.", this.PersonIds);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

