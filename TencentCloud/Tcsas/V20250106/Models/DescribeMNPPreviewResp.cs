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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPPreviewResp : AbstractModel
    {
        
        /// <summary>
        /// Mini program ID
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Mini program name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// Mini program description
        /// </summary>
        [JsonProperty("MNPDesc")]
        public string MNPDesc{ get; set; }

        /// <summary>
        /// Mini program version.
        /// </summary>
        [JsonProperty("MNPVersion")]
        public string MNPVersion{ get; set; }

        /// <summary>
        /// Describes the mini program version.
        /// </summary>
        [JsonProperty("MNPVersionIntro")]
        public string MNPVersionIntro{ get; set; }

        /// <summary>
        /// Specifies the mini program qr code.
        /// </summary>
        [JsonProperty("QRCodeUrl")]
        public string QRCodeUrl{ get; set; }

        /// <summary>
        /// Specifies the path to the preview version.
        /// </summary>
        [JsonProperty("PreviewEntrancePath")]
        public string PreviewEntrancePath{ get; set; }

        /// <summary>
        /// Specifies the qr code content.
        /// </summary>
        [JsonProperty("QRCodeContent")]
        public string QRCodeContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPDesc", this.MNPDesc);
            this.SetParamSimple(map, prefix + "MNPVersion", this.MNPVersion);
            this.SetParamSimple(map, prefix + "MNPVersionIntro", this.MNPVersionIntro);
            this.SetParamSimple(map, prefix + "QRCodeUrl", this.QRCodeUrl);
            this.SetParamSimple(map, prefix + "PreviewEntrancePath", this.PreviewEntrancePath);
            this.SetParamSimple(map, prefix + "QRCodeContent", this.QRCodeContent);
        }
    }
}

