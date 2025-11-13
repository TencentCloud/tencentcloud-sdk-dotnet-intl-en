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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTranscodeTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID filter of transcoding templates. Array length limit: 100.
        /// </summary>
        [JsonProperty("Definitions")]
        public long?[] Definitions{ get; set; }

        /// <summary>
        /// Template type filter. Valid values:
        /// <li>Preset: Preset template;</li>
        /// <li>Custom: Custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Container format filter. Valid values:
        /// <li>Video: Video container format that can contain both video stream and audio stream;</li>
        /// <li>PureAudio: Audio container format that can contain only audio stream.</li>
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// TESHD filter, which is used to filter common transcoding or ultra-fast HD transcoding templates. Valid values:
        /// <li>Common: Common transcoding template;</li>
        /// <li>TEHD: TESHD template.</li>
        /// </summary>
        [JsonProperty("TEHDType")]
        public string TEHDType{ get; set; }

        /// <summary>
        /// Paging offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The template type (replacing `TEHDType`). Valid values:
        /// <li>Common: Common transcoding template</li>
        /// <li>TEHD: TESHD template</li>
        /// <li>Enhance: Audio/Video enhancement template.</li>
        /// This parameter is left empty by default, which indicates to return all types of templates.
        /// </summary>
        [JsonProperty("TranscodeType")]
        public string TranscodeType{ get; set; }

        /// <summary>
        /// Filter condition for transcoding template identifiers, with a length limit of 64 characters.	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Video scenario. Optional values: 
        /// normal: General transcoding scenario: General transcoding and compression scenario. 
        /// pgc: PGC HD TV shows and movies: At the time of compression, focus is placed on the viewing experience of TV shows and movies and ROI encoding is performed according to their characteristics, while high-quality contents of videos and audio are retained. 
        /// materials_video: HD materials: Scenario involving material resources, where requirements for image quality are extremely high and there are many transparent images, with almost no visual loss during compression. 
        /// ugc: UGC content: It is suitable for a wide range of UGC/short video scenarios, with an optimized encoding bitrate for short video characteristics, improved image quality, and enhanced business QOS/QOE metrics. 
        /// e-commerce_video: Fashion show/e-commerce: At the time of compression, emphasis is placed on detail clarity and ROI enhancement, with a particular focus on maintaining the image quality of the face region. 
        /// educational_video: Education: At the time of compression, emphasis is placed on the clarity and readability of text and images to help students better understand the content, ensuring that the teaching content is clearly conveyed. 
        /// no_config: Not configured.
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// Transcoding policy. Optional values: 
        /// ultra_compress: Extreme compression: Compared to standard compression, this policy can maximize bitrate compression while ensuring a certain level of image quality, thus greatly saving bandwidth and storage costs. 
        /// standard_compress: Comprehensively optimal: The compression ratio and image quality are balanced, and files are compressed as much as possible without a noticeable reduction in subjective image quality. Only audio and video TSC transcoding fees are charged for this policy. 
        /// high_compress: Bitrate priority: Priority is given to reducing file size, which may result in certain image quality loss. Only audio and video TSC transcoding fees are charged for this policy. 
        /// low_compress: Image quality priority: Priority is given to ensuring image quality, and the size of compressed files may be relatively large. Only audio and video TSC transcoding fees are charged for this policy. 
        /// no_config: Not configured.
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        /// <summary>
        /// Enhancement scenario configuration. Valid values:
        /// <li>common: common enhancement parameters, which are basic optimization parameters suitable for various video types, enhancing overall image quality.</li>
        /// <li>AIGC: overall resolution enhancement. It uses AI technology to improve the overall video resolution and image clarity.</li>
        /// <li>short_play: enhance facial and subtitle details, emphasizing characters' facial expressions and subtitle clarity to improve the viewing experience.</li>
        /// <li>short_video: optimize complex and diverse image quality issues, tailoring quality enhancements for the complex scenarios such as short videos to address various visual issues.</li>
        /// <li>game: fix motion blur and enhance details, with a focus on enhancing the clarity of game details and restoring blurry areas during motions to make the image content during gaming clearer and richer.</li>
        /// <li>HD_movie_series: provide a smooth playback effect for UHD videos. Standard 4K HDR videos with an FPS of 60 are generated to meet the needs of broadcasting/OTT for UHD videos. Formats for broadcasting scenarios are supported.</li>
        /// <li>LQ_material: low-definition material/old video restoration. It enhances overall resolution, and solves issues of old videos, such as low resolution, blur, distortion, scratches, and color temperature due to their age.</li>
        /// <li>lecture: live shows, e-commerce, conferences, and lectures. It improves the face display effect and performs specific optimizations, including face region enhancement, noise reduction, and artifacts removal, for scenarios involving human explanation, such as live shows, e-commerce, conferences, and lectures.</li>
        /// </summary>
        [JsonProperty("EnhanceSceneType")]
        public string EnhanceSceneType{ get; set; }

        /// <summary>
        /// Enhanced transcoding type. Valid values:
        /// <li>Common: standard transcoding.</li>
        /// <li>TEHD-100: top speed codec video transcoding.</li>
        /// <li>TEHD-200: top speed codec audio transcoding.</li>
        /// </summary>
        [JsonProperty("EnhanceTranscodeType")]
        public string EnhanceTranscodeType{ get; set; }

        /// <summary>
        /// Enhancement type. Valid values:
        /// <li>VideoEnhance: video enhancement only.</li>
        /// <li>AudioEnhance (audio enhancement only).</li>
        /// <li>VideoAudioEnhance: video and audio enhancement included.</li>
        /// </summary>
        [JsonProperty("EnhanceType")]
        public string EnhanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Definitions.", this.Definitions);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ContainerType", this.ContainerType);
            this.SetParamSimple(map, prefix + "TEHDType", this.TEHDType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TranscodeType", this.TranscodeType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
            this.SetParamSimple(map, prefix + "EnhanceSceneType", this.EnhanceSceneType);
            this.SetParamSimple(map, prefix + "EnhanceTranscodeType", this.EnhanceTranscodeType);
            this.SetParamSimple(map, prefix + "EnhanceType", this.EnhanceType);
        }
    }
}

