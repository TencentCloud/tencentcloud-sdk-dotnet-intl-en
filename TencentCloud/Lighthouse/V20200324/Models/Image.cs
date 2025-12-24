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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Image : AbstractModel
    {
        
        /// <summary>
        /// CVM Image ID, which is the unique identifier of the image.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image description.
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// Image size, in GB.
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// Image source.
        /// <li>CREATE_IMAGE: custom image.</li>
        /// <li>EXTERNAL_IMPORT: externally imported image.</li>
        /// </summary>
        [JsonProperty("ImageSource")]
        public string ImageSource{ get; set; }

        /// <summary>
        /// Image classification.
        /// <li>SystemImage: system disk image.</li>
        /// <li>InstanceImage: full-instance image.</li>
        /// </summary>
        [JsonProperty("ImageClass")]
        public string ImageClass{ get; set; }

        /// <summary>
        /// Image status.
        /// CREATING: creating.
        /// NORMAL: normal.
        /// CREATEFAILED: creation failed.
        /// USING: in use.
        /// SYNCING: synchronizing.
        /// IMPORTING: importing.
        /// IMPORTFAILED: import failed.
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// Whether the image supports Cloudinit.
        /// </summary>
        [JsonProperty("IsSupportCloudinit")]
        public bool? IsSupportCloudinit{ get; set; }

        /// <summary>
        /// Image architecture.
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// Image operating system.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Image source platform.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Image creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Whether the image can be shared to Lighthouse.
        /// </summary>
        [JsonProperty("IsShareable")]
        public bool? IsShareable{ get; set; }

        /// <summary>
        /// Reason for not being shared.
        /// </summary>
        [JsonProperty("UnshareableReason")]
        public string UnshareableReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageSource", this.ImageSource);
            this.SetParamSimple(map, prefix + "ImageClass", this.ImageClass);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "IsSupportCloudinit", this.IsSupportCloudinit);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "IsShareable", this.IsShareable);
            this.SetParamSimple(map, prefix + "UnshareableReason", this.UnshareableReason);
        }
    }
}

