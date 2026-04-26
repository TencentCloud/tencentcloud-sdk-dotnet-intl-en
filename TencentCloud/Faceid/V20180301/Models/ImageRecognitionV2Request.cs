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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRecognitionV2Request : AbstractModel
    {
        
        /// <summary>
        /// <p>Identity card number.</p>
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// <p>Name.</p><ul><li>For Chinese, please use UTF-8 encode.</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Image for face comparison, the Base64 value of the image.<br>The size of the Base64-encoded image data should be no more than 3M. Only jpg and png formats are supported.<br>Please use the standard Base64 encoding type (with = padding). Refer to RFC4648 for the coding specification.</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>This parameter is not required for this API.</p>
        /// </summary>
        [JsonProperty("Optional")]
        public string Optional{ get; set; }

        /// <summary>
        /// <p>Sensitive data encryption information.</p><ul><li>Users with encryption requirements for incoming information (name, identity card number) can use this parameter. For details, please click the left-side link.</li></ul>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// <p>Customized description field.</p><ul><li>For description of invoke business info. This description field will return in the output.</li><li>Each customized description field supports [1,10] characters.</li></ul>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Optional", this.Optional);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

