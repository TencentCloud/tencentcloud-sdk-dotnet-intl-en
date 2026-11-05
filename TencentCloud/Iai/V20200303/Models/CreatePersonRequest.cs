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

    public class CreatePersonRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the personnel database to be added, which is the GroupId in the API for creating a personnel database.</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>Person name. [1, 60] characters, modifiable, repeatable.</p>
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// <p>Person ID.</p><ul><li>Cannot be modified or repeated under a single Tencent Cloud account.</li><li>Supports English letters, digits, -%@#&amp;_, length limited to 64B.</li></ul>
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// <p>Gender.</p><ul><li>Value range: 0 represents empty, 1 represents man, 2 represents woman.</li></ul>
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// <p>Person description field content, key-value. [0, 60] characters, modifiable, repeatable.</p>
        /// </summary>
        [JsonProperty("PersonExDescriptionInfos")]
        public PersonExDescriptionInfo[] PersonExDescriptionInfos{ get; set; }

        /// <summary>
        /// <p>base64 image data.</p><ul><li>base64-encoded data must not exceed 5 MB.</li><li>For jpg images, the long edge must not exceed 4000 pixels. For other formats, the long edge must not exceed 2000 pixels. The short edge of images in all formats must be at least 64 pixels.</li><li>PNG, jpg, JPEG, and BMP are supported. GIF images are not supported.</li></ul>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>Image Url.</p><ul><li>The corresponding Image size after base64 encoding must not exceed 5M.</li><li>For jpg format, the long side pixel cannot exceed 4000. For other formats, the long side pixel cannot exceed 2000. The short side pixel of images in all formats must not be less than 64.</li><li>Either Url or Image must be provided. If both are provided, only Url is used.</li><li>Images stored in Tencent Cloud's Url can guarantee higher download speed and stability. It is recommended to store images in Tencent Cloud.</li><li>The speed and stability of URLs not stored in Tencent Cloud may be affected to a certain extent.</li><li>PNG, jpg, JPEG, and BMP are supported. GIF images are not supported.</li></ul>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>This parameter is used to control whether the human face contained in the image specified by Image or Url is determined to be a suspected duplicate person already existing in the person library. </p><ul><li>If determined to be the same person already in the person library, no new person will be created, and the personnel information of the suspected duplicate person will be returned. </li><li>If not, the person will be created. </li><li>Value range:<br>0: No judgment is performed, and the person will be stored regardless of whether there is a suspected duplicate person in the library;<br>1: Low duplicate person judgment requirement (1% false recognition rate);<br>2: Normal duplicate person judgment requirement (0.1% false recognition rate);<br>3: High duplicate person judgment requirement (0.01% false recognition rate);<br>4: Very high duplicate person judgment requirement (0.001% false recognition rate). </li><li>Default value: 0. </li><li>Note: The higher the requirement, the lower the probability of suspected duplicate persons. The false recognition rates for different requirements are for reference only and can be adjusted according to the actual situation.</li></ul>
        /// </summary>
        [JsonProperty("UniquePersonControl")]
        public ulong? UniquePersonControl{ get; set; }

        /// <summary>
        /// <p>Image quality control. </p><ul><li>Value range: <br>0: no control; <br>1: low quality requirement, where the image is very blurry, or at least one or more of the eyes, nose, or mouth are occluded; <br>2: general quality requirement, where the image is bright, dark, blurry or generally blurry, with at least three of the following: eyebrow occlusion, cheek occlusion, or chin occlusion; <br>3: high quality requirement, where the image is bright, dark, generally blurry, with one or two of the following: eyebrow occlusion, cheek occlusion, or chin occlusion; <br>4: very high quality requirement, where each dimension is optimal or at most one dimension has a minor problem; </li><li>Default: 0. </li><li>If the image quality fails to satisfy the requirement, the returned result will prompt that the image quality detection does not meet the requirement.</li></ul>
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// <p>Whether to enable image rotation recognition support.</p><ul><li>Value range: 0 for disabled, 1 for enabled.</li><li>Default value: 0.</li><li>This parameter is used to correctly detect and recognize human faces in an image when the faces are rotated and the image has no exif information. If image rotation recognition support is not enabled in this case, the faces cannot be detected or recognized.</li><li>If you confirm that the image contains exif information or that the human faces in the input image will not be rotated, do not enable this parameter. Once enabled, the overall duration may increase by several hundred milliseconds.</li></ul>
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public ulong? NeedRotateDetection{ get; set; }

        /// <summary>
        /// <p>Whether to encrypt the entire request body. Supported encryption algorithm: AES-256-CBC. Users with encryption requirements can use this parameter.</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// <p>Encrypted ciphertext. The data format before encryption is as follows: {&quot;Url&quot;:&quot;<strong>&quot;,&quot;Image&quot;:&quot;</strong>&quot;}.</p>
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamArrayObj(map, prefix + "PersonExDescriptionInfos.", this.PersonExDescriptionInfos);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "UniquePersonControl", this.UniquePersonControl);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
        }
    }
}

