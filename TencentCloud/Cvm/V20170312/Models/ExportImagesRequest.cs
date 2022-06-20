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

    public class ExportImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// COS bucket name
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// List of image IDs
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// Format of the exported image file. Valid values: `RAW`, `QCOW2`, `VHD` and `VMDK`. Default value: `RAW`.
        /// </summary>
        [JsonProperty("ExportFormat")]
        public string ExportFormat{ get; set; }

        /// <summary>
        /// Prefix list of the name of exported files
        /// </summary>
        [JsonProperty("FileNamePrefixList")]
        public string[] FileNamePrefixList{ get; set; }

        /// <summary>
        /// Whether to export only the system disk
        /// </summary>
        [JsonProperty("OnlyExportRootDisk")]
        public bool? OnlyExportRootDisk{ get; set; }

        /// <summary>
        /// Check whether the image can be exported
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Role name (Default: `CVM_QcsRole`). Before exporting the images, make sure the role exists, and it has write permission to COS.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamSimple(map, prefix + "ExportFormat", this.ExportFormat);
            this.SetParamArraySimple(map, prefix + "FileNamePrefixList.", this.FileNamePrefixList);
            this.SetParamSimple(map, prefix + "OnlyExportRootDisk", this.OnlyExportRootDisk);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

