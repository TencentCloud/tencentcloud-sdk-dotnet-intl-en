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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceType : AbstractModel
    {
        
        /// <summary>
        /// Resource group type
        /// 
        /// -Schedule --- scheduling resource group.
        /// -Integration - integration resource group.
        /// -DataService - data service resource group.
        /// </summary>
        [JsonProperty("ResourceGroupType")]
        public string ResourceGroupType{ get; set; }

        /// <summary>
        /// Integration resource group, segmentation of real-time resource group and offline resource group (simultaneous purchase of integration, scheduling, and data service resource group not allowed).
        /// </summary>
        [JsonProperty("Integration")]
        public IntegrationResource Integration{ get; set; }

        /// <summary>
        /// Scheduling resource group (simultaneous purchase of integration, scheduling, and data service resource groups is not allowed).
        /// 
        /// -test specification.
        /// -S_small (basic specification).
        /// -S_medium (general specifications).
        /// -S_large (professional specification).
        /// 
        /// 
        /// </summary>
        [JsonProperty("Schedule")]
        public ResourceGroupSpecification Schedule{ get; set; }

        /// <summary>
        /// Data service resource group (seamless integration, scheduling, simultaneous purchase not allowed).
        /// 
        /// -ds_t(Test specification).
        /// -ds_s (basic specification).
        /// -ds_m (general specifications).
        /// -ds_l (professional specification).
        /// </summary>
        [JsonProperty("DataService")]
        public ResourceGroupSpecification DataService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroupType", this.ResourceGroupType);
            this.SetParamObj(map, prefix + "Integration.", this.Integration);
            this.SetParamObj(map, prefix + "Schedule.", this.Schedule);
            this.SetParamObj(map, prefix + "DataService.", this.DataService);
        }
    }
}

