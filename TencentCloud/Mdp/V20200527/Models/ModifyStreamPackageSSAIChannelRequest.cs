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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStreamPackageSSAIChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Ad insertion configuration name, globally unique, cannot be repeated.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Content source prefix.
        /// </summary>
        [JsonProperty("ContentSource")]
        public string ContentSource{ get; set; }

        /// <summary>
        /// Ad insertion configuration information
        /// </summary>
        [JsonProperty("SSAIInfo")]
        public SSAIConf SSAIInfo{ get; set; }

        /// <summary>
        /// Ad insertion configuration ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ContentSource", this.ContentSource);
            this.SetParamObj(map, prefix + "SSAIInfo.", this.SSAIInfo);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

