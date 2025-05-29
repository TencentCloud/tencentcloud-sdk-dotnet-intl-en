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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUsageCallDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Model identifier.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Uin list.
        /// </summary>
        [JsonProperty("UinAccount")]
        public string[] UinAccount{ get; set; }

        /// <summary>
        /// Application ID list.
        /// </summary>
        [JsonProperty("AppBizIds")]
        public string[] AppBizIds{ get; set; }

        /// <summary>
        /// Call type list.
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// Filter sub-scenario.
        /// </summary>
        [JsonProperty("SubScenes")]
        public string[] SubScenes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "UinAccount.", this.UinAccount);
            this.SetParamArraySimple(map, prefix + "AppBizIds.", this.AppBizIds);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamArraySimple(map, prefix + "SubScenes.", this.SubScenes);
        }
    }
}

