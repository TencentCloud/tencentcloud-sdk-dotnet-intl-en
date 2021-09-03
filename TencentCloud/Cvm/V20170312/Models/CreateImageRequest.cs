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

    public class CreateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// ID of the instance from which an image will be created. This parameter is required when using instance to create an image.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Image description
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// Whether to force shut down an instance to create an image when a soft shutdown fails
        /// </summary>
        [JsonProperty("ForcePoweroff")]
        public string ForcePoweroff{ get; set; }

        /// <summary>
        /// Whether to enable Sysprep when creating a Windows image.
        /// Valid values: `TRUE` and `FALSE`; default value: `FALSE`.
        /// 
        /// Click [here](https://intl.cloud.tencent.com/document/product/213/43498?from_cn_redirect=1) to learn more about Sysprep.
        /// </summary>
        [JsonProperty("Sysprep")]
        public string Sysprep{ get; set; }

        /// <summary>
        /// Specified data disk ID included in the full image created from the instance.
        /// </summary>
        [JsonProperty("DataDiskIds")]
        public string[] DataDiskIds{ get; set; }

        /// <summary>
        /// Specified snapshot ID used to create an image. A system disk snapshot must be included. It cannot be passed together with `InstanceId`.
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// Success status of this request, without affecting the resources involved
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ForcePoweroff", this.ForcePoweroff);
            this.SetParamSimple(map, prefix + "Sysprep", this.Sysprep);
            this.SetParamArraySimple(map, prefix + "DataDiskIds.", this.DataDiskIds);
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

