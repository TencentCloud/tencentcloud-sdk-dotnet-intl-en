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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAliasRequest : AbstractModel
    {
        
        /// <summary>
        /// Function name
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Alias name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Master version of alias
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Routing information of alias, which is required if you need to specify an additional version for the alias.
        /// </summary>
        [JsonProperty("RoutingConfig")]
        public RoutingConfig RoutingConfig{ get; set; }

        /// <summary>
        /// Alias description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamObj(map, prefix + "RoutingConfig.", this.RoutingConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

