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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Person ID, which is the PersonId in the person creation API.</p>
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// <p>base64 data of the image.</p><ul><li>base64 encoded size must not exceed 5M.</li><li>For jpg format, the long side pixel must not exceed 4000. For other formats, the image long edge must not exceed 2000. The short side pixel of images in all formats must be not less than 64.</li><li>The total number of faces must not exceed 5.</li><li>If the image contains several faces, only the face with the maximum area is selected.</li><li>PNG, jpg, JPEG, and BMP are supported. GIF images are not supported.</li></ul>
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// <p>Image Url.</p><ul><li>The size of the corresponding Image after base64 encoding must not exceed 5M.</li><li>For jpg format, the long side pixel must not exceed 4000. For other Image formats, the long side pixel must not exceed 2000. The short side pixel of images in all formats must be not less than 64.</li><li>Either Url or Image must be provided. If both are provided, only Url is used.</li><li>Images stored in Tencent Cloud URLs can guarantee higher download speed and stability. It is recommended to store images in Tencent Cloud.</li><li>The speed and stability of non-Tencent Cloud Storage URLs may be affected to a certain extent.</li><li>PNG, jpg, JPEG, and BMP are supported. GIF images are not supported.</li><li>The total number of human faces must not exceed 5.</li><li>If the Image contains several faces, only the face with the maximum area is selected.</li></ul>
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// <p>Only faces with a similarity to the person's existing faces exceeding the FaceMatchThreshold can be added successfully. </p><ul><li>Default value: 60. </li><li>Value range: [0,100]. </li></ul>
        /// </summary>
        [JsonProperty("FaceMatchThreshold")]
        public float? FaceMatchThreshold{ get; set; }

        /// <summary>
        /// <p>Image quality control. </p><ul><li>Value range: <br>0: no control; <br>1: low quality requirement, where the image is super blurry, or at least one or more of the following exist: eye occlusion, nose occlusion, or mouth occlusion; <br>2: normal quality requirement, where the image is bright, dark, blurry or generally blurry, or at least three of the following exist: eyebrow obstruction, cheek obstruction, or chin obstruction; <br>3: high quality requirement, where the image is bright, dark, generally blurry, or one to two of the following exist: eyebrow obstruction, cheek obstruction, or chin obstruction; <br>4: super high quality requirement, where each dimension is at its best or at most one dimension has a minor problem; </li><li>Default: 0. </li><li>If the image quality fails to satisfy the requirement, the returned result will prompt that the image quality detection does not meet the requirement.</li></ul>
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// <p>Whether to enable image rotation recognition support.</p><ul><li>Value range: 0 means not enabled, 1 means enabled.</li><li>Default value: 0.</li><li>This parameter is used when the human face in the image is rotated and the image has no exif information. If image rotation recognition support is not enabled, the human face in the image cannot be correctly detected or recognized.</li><li>If you confirm that the image contains exif information or that the human face in the input image will not be rotated, do not enable this parameter. Once enabled, the overall duration may increase by several hundred milliseconds.</li></ul>
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public ulong? NeedRotateDetection{ get; set; }

        /// <summary>
        /// <p>Whether full-body encryption is required for the request information. Supported encryption algorithm: AES-256-CBC. Users with encryption requirements can use this parameter.</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// <p>Encrypted ciphertext. The data format before encryption is as follows: {&quot;Url&quot;:&quot;<strong>&quot;,&quot;Image&quot;:&quot;</strong>&quot;}。</p>
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "FaceMatchThreshold", this.FaceMatchThreshold);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
        }
    }
}

