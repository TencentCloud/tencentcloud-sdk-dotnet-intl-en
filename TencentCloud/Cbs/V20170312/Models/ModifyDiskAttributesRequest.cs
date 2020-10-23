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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDiskAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// IDs of one or more cloud disks to be operated. If multiple cloud disk IDs are selected, it only supports modifying all cloud disks with the same attributes.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// The new project ID of the cloud disk. Only the project ID of elastic cloud disk can be modified. The available projects and their IDs can be queried via the API [DescribeProject](https://intl.cloud.tencent.com/document/api/378/4400?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Name of new cloud disk.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// Whether it is an elastic cloud disk. FALSE: non-elastic cloud disk; TRUE: elastic cloud disk. You can only modify non-elastic cloud disks to elastic cloud disks.
        /// </summary>
        [JsonProperty("Portable")]
        public bool? Portable{ get; set; }

        /// <summary>
        /// Whether the cloud disk is terminated with the CVM after it has been successfully mounted. `TRUE` indicates that it is terminated with the CVM. `FALSE` indicates that it is not terminated with the CVM. This is only supported for cloud disks and data disks that are pay-as-you-go.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// When changing the type of a cloud disk, this parameter can be passed to indicate the desired cloud disk type. Value range: <br><li>CLOUD_PREMIUM: Premium cloud storage.  <br><li>CLOUD_SSD: SSD cloud disk. <br>Currently, batch operations are not supported for changing type. That is, when `DiskType` is passed, only one cloud disk can be passed through `DiskIds`. <br>When the cloud disk type is changed, the changing of other attributes is not supported concurrently.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamSimple(map, prefix + "Portable", this.Portable);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
        }
    }
}

