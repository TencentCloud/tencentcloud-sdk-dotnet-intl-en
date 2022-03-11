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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Image : AbstractModel
    {
        
        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image status
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// Image type
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// OS name
        /// </summary>
        [JsonProperty("ImageOsName")]
        public string ImageOsName{ get; set; }

        /// <summary>
        /// Image description
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// Image import time
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// Number of bits of the OS
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// OS type
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// OS version
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// OS platform
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Image owner
        /// </summary>
        [JsonProperty("ImageOwner")]
        public long? ImageOwner{ get; set; }

        /// <summary>
        /// Image size in GB
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// Image source information
        /// </summary>
        [JsonProperty("SrcImage")]
        public SrcImage SrcImage{ get; set; }

        /// <summary>
        /// Image source type
        /// </summary>
        [JsonProperty("ImageSource")]
        public string ImageSource{ get; set; }

        /// <summary>
        /// ID of the task in intermediate or failed status
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Whether cloud-init is supported
        /// </summary>
        [JsonProperty("IsSupportCloudInit")]
        public bool? IsSupportCloudInit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageOsName", this.ImageOsName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ImageOwner", this.ImageOwner);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamObj(map, prefix + "SrcImage.", this.SrcImage);
            this.SetParamSimple(map, prefix + "ImageSource", this.ImageSource);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "IsSupportCloudInit", this.IsSupportCloudInit);
        }
    }
}

