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

    public class Image : AbstractModel
    {
        
        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Operating system of the image
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Image type
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// Creation time of the image
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image description
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// Image size
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// Image architecture
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// Image state
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// Source platform of the image
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Image creator
        /// </summary>
        [JsonProperty("ImageCreator")]
        public string ImageCreator{ get; set; }

        /// <summary>
        /// Image source
        /// </summary>
        [JsonProperty("ImageSource")]
        public string ImageSource{ get; set; }

        /// <summary>
        /// Synchronization percentage
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SyncPercent")]
        public long? SyncPercent{ get; set; }

        /// <summary>
        /// Whether the image supports cloud-init
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("IsSupportCloudinit")]
        public bool? IsSupportCloudinit{ get; set; }

        /// <summary>
        /// Information on the snapshots associated with the image
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SnapshotSet")]
        public Snapshot[] SnapshotSet{ get; set; }

        /// <summary>
        /// The list of tags bound to the image.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Image license type
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Image family, Note: This field may return empty
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// Whether the image is deprecated
        /// </summary>
        [JsonProperty("ImageDeprecated")]
        public bool? ImageDeprecated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ImageCreator", this.ImageCreator);
            this.SetParamSimple(map, prefix + "ImageSource", this.ImageSource);
            this.SetParamSimple(map, prefix + "SyncPercent", this.SyncPercent);
            this.SetParamSimple(map, prefix + "IsSupportCloudinit", this.IsSupportCloudinit);
            this.SetParamArrayObj(map, prefix + "SnapshotSet.", this.SnapshotSet);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "ImageDeprecated", this.ImageDeprecated);
        }
    }
}

