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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyImageAuthorizedRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to license all local images, which has a higher priority than licensing by local image ID. When it is `true`, `UpdatedLocalImageCnt` should be greater than `0`.
        /// </summary>
        [JsonProperty("AllLocalImages")]
        public bool? AllLocalImages{ get; set; }

        /// <summary>
        /// Whether to license all repository images, with a higher priority than licensing by image ID. When it is `true`, `UpdatedRegistryImageCnt` should be greater than `0`.
        /// </summary>
        [JsonProperty("AllRegistryImages")]
        public bool? AllRegistryImages{ get; set; }

        /// <summary>
        /// Specified number of local images to be licensed, with the highest priority. Any difference between this number and the actual number will be randomly ignored.
        /// </summary>
        [JsonProperty("UpdatedLocalImageCnt")]
        public ulong? UpdatedLocalImageCnt{ get; set; }

        /// <summary>
        /// Specified number of repository images to be licensed, with the highest priority. Any difference between this number and the actual number will be randomly ignored.
        /// </summary>
        [JsonProperty("UpdatedRegistryImageCnt")]
        public ulong? UpdatedRegistryImageCnt{ get; set; }

        /// <summary>
        /// Licensing by eligible local images. Valid values of local image source: `ASSETIMAGE` (local image list); `IMAGEALL` (local image sync). This parameter is required when `AllLocalImages` is `false`, `LocalImageIds` is empty, and `UpdatedLocalImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("ImageSourceType")]
        public string ImageSourceType{ get; set; }

        /// <summary>
        /// Licensing by eligible local images. This parameter is required when `AllLocalImages` is `false`, `LocalImageIds` is empty, and `UpdatedLocalImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("LocalImageFilter")]
        public AssetFilters[] LocalImageFilter{ get; set; }

        /// <summary>
        /// Licensing by eligible repository images. This parameter is required when `AllRegistryImages` is `false`, `RegistryImageIds` is empty, and `UpdatedRegistryImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("RegistryImageFilter")]
        public AssetFilters[] RegistryImageFilter{ get; set; }

        /// <summary>
        /// Licensing by eligible images, excluding specified local image IDs
        /// </summary>
        [JsonProperty("ExcludeLocalImageIds")]
        public string[] ExcludeLocalImageIds{ get; set; }

        /// <summary>
        /// Licensing by eligible images, excluding specified repository image IDs
        /// </summary>
        [JsonProperty("ExcludeRegistryImageIds")]
        public string[] ExcludeRegistryImageIds{ get; set; }

        /// <summary>
        /// Licensing by local image ID. This parameter has a higher priority than licensing by eligible images. It is required when `AllLocalImages` is `false`, `LocalImageFilter` is empty, and `UpdatedLocalImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("LocalImageIds")]
        public string[] LocalImageIds{ get; set; }

        /// <summary>
        /// Licensing by repository image ID. This parameter has a higher priority than licensing by eligible images. It is required when `AllRegistryImages` is `false`, `RegistryImageFilter` is empty, and `UpdatedRegistryImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("RegistryImageIds")]
        public string[] RegistryImageIds{ get; set; }

        /// <summary>
        /// Whether to only include latest images. This parameter is required for repository images when `RegistryImageFilter` is not empty and `UpdatedRegistryImageCnt` is greater than `0`.
        /// </summary>
        [JsonProperty("OnlyShowLatest")]
        public bool? OnlyShowLatest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllLocalImages", this.AllLocalImages);
            this.SetParamSimple(map, prefix + "AllRegistryImages", this.AllRegistryImages);
            this.SetParamSimple(map, prefix + "UpdatedLocalImageCnt", this.UpdatedLocalImageCnt);
            this.SetParamSimple(map, prefix + "UpdatedRegistryImageCnt", this.UpdatedRegistryImageCnt);
            this.SetParamSimple(map, prefix + "ImageSourceType", this.ImageSourceType);
            this.SetParamArrayObj(map, prefix + "LocalImageFilter.", this.LocalImageFilter);
            this.SetParamArrayObj(map, prefix + "RegistryImageFilter.", this.RegistryImageFilter);
            this.SetParamArraySimple(map, prefix + "ExcludeLocalImageIds.", this.ExcludeLocalImageIds);
            this.SetParamArraySimple(map, prefix + "ExcludeRegistryImageIds.", this.ExcludeRegistryImageIds);
            this.SetParamArraySimple(map, prefix + "LocalImageIds.", this.LocalImageIds);
            this.SetParamArraySimple(map, prefix + "RegistryImageIds.", this.RegistryImageIds);
            this.SetParamSimple(map, prefix + "OnlyShowLatest", this.OnlyShowLatest);
        }
    }
}

