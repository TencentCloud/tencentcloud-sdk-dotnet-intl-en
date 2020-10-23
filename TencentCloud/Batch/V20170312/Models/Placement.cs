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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Placement : AbstractModel
    {
        
        /// <summary>
        /// The ID of [availability zone](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo) where the instance locates. It can obtained in the `Zone` field returned by [DescribeZones](https://intl.cloud.tencent.com/document/213/15707?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// ID of the project to which the instance belongs. To obtain the project IDs, you can call [DescribeProject](https://intl.cloud.tencent.com/document/api/378/4400?from_cn_redirect=1) and look for the `projectId` fields in the response. If this parameter is not specified, the default project will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// ID list of CDHs from which the instance can be created. If you have purchased CDHs and specify this parameter, the instances you purchase will be randomly deployed on the CDHs.
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// Master host IP used to create the CVM
        /// </summary>
        [JsonProperty("HostIps")]
        public string[] HostIps{ get; set; }

        /// <summary>
        /// The ID of the CDH to which the instance belongs, only used as an output parameter.
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "HostIps.", this.HostIps);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
        }
    }
}

