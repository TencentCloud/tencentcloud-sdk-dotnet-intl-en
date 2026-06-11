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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAigcAdvancedCustomElementRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Subject name cannot exceed 20 characters.</p>
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// <p>Subject description, with a length limit of 100 characters.</p>
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// <p>Reference method for the subject. The availability area differs between subjects customized via video and those customized via images.</p><p>Enumeration value:</p><ul><li>video_refer: Video character subject. At this point, the subject appearance is defined by referring to element_video_list.</li><li>image_refer: Multi-image subject. At this point, the subject appearance is defined by referring to element_image_list.</li></ul>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// <p>Voice type of the current entity. You can bind an existing timbre from the timbre library.</p><ul><li>When the current parameter is empty, the current entity is not bound to a timbre.</li><li>Only customized video entities support binding a timbre.</li></ul>
        /// </summary>
        [JsonProperty("ElementVoiceId")]
        public string ElementVoiceId{ get; set; }

        /// <summary>
        /// <p>Reference video for the entity. You can set the entity and its details through the video.</p><ul><li>You can upload a video with sound. If the video contains voice, it will trigger timbre customization (customization + adding to the timbre library + binding to the entity).</li><li>The current parameter is required when referencing a video and is invalid when referencing an image.</li><li>Use key:value pairs as follows:<br><pre><code>{  "refer_videos":[    {      "video_url":"video_url_1"    }  ]}</code></pre>● Only MP4/MOV video formats are supported.<br>● Only 1080p videos with a duration between 3s–8s and an aspect ratio of 16:9 or 9:16 are supported.<br>● Up to 1 video can be uploaded, with a video size of no more than 200MB.<br>● The video_url parameter value cannot be empty.</li></ul>
        /// </summary>
        [JsonProperty("ElementVideoList")]
        public string ElementVideoList{ get; set; }

        /// <summary>
        /// <p>Reference images of the subject can be set with multiple images and its details.</p><ul><li>Including front reference images and other perspectives or close-up reference images. Among them:<ul><li>At least 1 front reference image is required, defined by the frontal_image parameter.</li><li>1–3 other reference images are required, with differences from the front reference image, defined by the image_url parameter.</li></ul></li><li>Use key:value to carry, as follows:<br><pre><code>{  &quot;frontal_image&quot;:&quot;image_url_0&quot;,  &quot;refer_images&quot;:[    {      &quot;image_url&quot;:&quot;image_url_1&quot;    },    {      &quot;image_url&quot;:&quot;image_url_2&quot;    },    {      &quot;image_url&quot;:&quot;image_url_3&quot;    }  ]}</code></pre></li></ul>
        /// </summary>
        [JsonProperty("ElementImageList")]
        public string ElementImageList{ get; set; }

        /// <summary>
        /// <p>Configure tags for a subject. A subject can be configured with multiple tags.</p><ul><li>Use key:value pairs to carry them. Details are given below:</li></ul><p><pre><code>[  {        "tag_id": "o_101"  }, {        "tag_id": "o_102"    }]</code></pre></p>
        /// </summary>
        [JsonProperty("TagList")]
        public string TagList{ get; set; }

        /// <summary>
        /// <p>If the overseas custom subject library is enabled, you can input <code>True</code> to use it.</p><p>Enumeration value:</p><ul><li>True: Use the overseas custom subject library.</li><li>False: Non-use of the overseas custom subject library.</li></ul>
        /// </summary>
        [JsonProperty("DisableModeration")]
        public string DisableModeration{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass through user request information. The task complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value ranges from -10 to 10. If this is not specified, it represents 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "ElementDescription", this.ElementDescription);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ElementVoiceId", this.ElementVoiceId);
            this.SetParamSimple(map, prefix + "ElementVideoList", this.ElementVideoList);
            this.SetParamSimple(map, prefix + "ElementImageList", this.ElementImageList);
            this.SetParamSimple(map, prefix + "TagList", this.TagList);
            this.SetParamSimple(map, prefix + "DisableModeration", this.DisableModeration);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

