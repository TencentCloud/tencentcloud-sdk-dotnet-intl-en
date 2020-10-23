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

    public class ImportImageRequest : AbstractModel
    {
        
        /// <summary>
        /// OS architecture of the image to be imported, `x86_64` or `i386`.
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// OS type of the image to be imported. You can call `DescribeImportImageOs` to obtain the list of supported operating systems.
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// OS version of the image to be imported. You can call `DescribeImportImageOs` to obtain the list of supported operating systems.
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// Address on COS where the image to be imported is stored.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

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
        /// Dry run to check the parameters without performing the operation
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Whether to force import the image. For more information, see [Forcibly Import Image](https://intl.cloud.tencent.com/document/product/213/12849).
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

