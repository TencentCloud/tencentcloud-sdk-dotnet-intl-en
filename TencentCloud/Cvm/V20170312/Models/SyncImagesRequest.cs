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

    public class SyncImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// Image ID list. You can obtain the image IDs in the following ways:<br><li>Call the [DescribeImages](https://intl.cloud.tencent.com/document/api/213/15715?from_cn_redirect=1) API and find the value of `ImageId` in the response.</li><li>Obtain the image IDs in the [Image console](https://console.cloud.tencent.com/cvm/image).<br>The image IDs should meet the following requirement:</li><li>The image ID should correspond to an image in the `NORMAL` state.</li>For more information on image status, see [Image Data Table](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#Image).
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// List of target synchronization regions, which should meet the following requirements:<br><li>It should be a valid region.</li><li>If it is a custom image, the target synchronization region cannot be the source region.</li><li>If it is a shared image, the target synchronization region only supports the source region, meaning the shared image will be copied as a custom image in the source region.</li><li>Partial region synchronization is not supported currently. For details, see [Copying Images](https://intl.cloud.tencent.com/document/product/213/4943?from_cn_redirect=1#.E5.A4.8D.E5.88.B6.E8.AF.B4.E6.98.8E).</li>For specific regional parameters, refer to [Region](https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DestinationRegions")]
        public string[] DestinationRegions{ get; set; }

        /// <summary>
        /// Checks whether image synchronization can be initiated.
        /// 
        /// Default value: false.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Target image name. By default, the source image name is used.
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Whether to return the ID of the image created in the target region.
        /// 
        /// Default value: false.
        /// </summary>
        [JsonProperty("ImageSetRequired")]
        public bool? ImageSetRequired{ get; set; }

        /// <summary>
        /// Whether to synchronize as an encrypted custom image.
        /// Default value is `false`.
        /// Synchronization to an encrypted custom image is only supported within the same region.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// KMS key ID used when synchronizing to an encrypted custom image. 
        /// This parameter is valid only synchronizing to an encrypted image.
        /// If KmsKeyId is not specified, the default CBS cloud product KMS key is used.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArraySimple(map, prefix + "DestinationRegions.", this.DestinationRegions);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageSetRequired", this.ImageSetRequired);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

