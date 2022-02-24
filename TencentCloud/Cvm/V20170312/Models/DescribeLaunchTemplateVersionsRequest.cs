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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLaunchTemplateVersionsRequest : AbstractModel
    {
        
        /// <summary>
        /// The launch template ID
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// List of instance launch templates.
        /// </summary>
        [JsonProperty("LaunchTemplateVersions")]
        public ulong?[] LaunchTemplateVersions{ get; set; }

        /// <summary>
        /// The minimum version number specified, which defaults to 0.
        /// </summary>
        [JsonProperty("MinVersion")]
        public ulong? MinVersion{ get; set; }

        /// <summary>
        /// The maximum version number specified, which defaults to 30.
        /// </summary>
        [JsonProperty("MaxVersion")]
        public ulong? MaxVersion{ get; set; }

        /// <summary>
        /// The offset. Default value: 0. For more information on `Offset`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Specify whether to query the default version. This parameter and `LaunchTemplateVersions` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("DefaultVersion")]
        public bool? DefaultVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamArraySimple(map, prefix + "LaunchTemplateVersions.", this.LaunchTemplateVersions);
            this.SetParamSimple(map, prefix + "MinVersion", this.MinVersion);
            this.SetParamSimple(map, prefix + "MaxVersion", this.MaxVersion);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DefaultVersion", this.DefaultVersion);
        }
    }
}

