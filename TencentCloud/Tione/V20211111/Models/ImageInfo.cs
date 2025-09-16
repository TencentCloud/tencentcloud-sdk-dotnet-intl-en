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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInfo : AbstractModel
    {
        
        /// <summary>
        /// Image type. Valid values: TCR ( which indicates a Tencent Container Registry (TCR) image), CCR (which indicates a TCR Personal Edition image), PreSet (which indicates a platform preset image), and CUSTOM (which indicates a third-party custom image).
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// Image address.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// Region corresponding to the TCR image.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// Instance ID corresponding to the TCR image.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// Whether to allow exporting all content.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AllowSaveAllContent")]
        public bool? AllowSaveAllContent{ get; set; }

        /// <summary>
        /// Image name.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Whether to support data generation.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportDataPipeline")]
        public bool? SupportDataPipeline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "AllowSaveAllContent", this.AllowSaveAllContent);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "SupportDataPipeline", this.SupportDataPipeline);
        }
    }
}

