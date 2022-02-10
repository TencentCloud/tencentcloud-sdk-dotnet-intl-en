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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceDetailAttributesInfo : AbstractModel
    {
        
        /// <summary>
        /// Age. Value range: [0,65], where 65 indicates 65 years old or above. 
        /// If `FaceAttributesType` does not include `Age` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// Beauty score. Value range: [0,100]. 
        /// If `FaceAttributesType` does not include `Beauty` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Beauty")]
        public long? Beauty{ get; set; }

        /// <summary>
        /// Emotion, including relaxed, happy, surprised, angry, sad, disgusted, and scared. 
        /// The `Type` values of the `AttributeItem` include: 0: relaxed; 1: happy; 2: surprised; 3: angry; 4: sad; 5: disgusted; 6: scared.
        /// If `FaceAttributesType` does not include `Emotion` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Emotion")]
        public AttributeItem Emotion{ get; set; }

        /// <summary>
        /// Eye information, including whether glasses are worn, whether eyes are closed, whether the person has double eyelids, and the eye size. 
        /// If `FaceAttributesType` does not include `Eye` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Eye")]
        public Eye Eye{ get; set; }

        /// <summary>
        /// Eyebrow information, including whether the eyebrows are thick, curved, or long. 
        /// If `FaceAttributesType` does not include `Eyebrow` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Eyebrow")]
        public Eyebrow Eyebrow{ get; set; }

        /// <summary>
        /// Gender information. 
        /// The `Type` values of the `AttributeItem` include: 0: male; 1: female.	
        /// If `FaceAttributesType` does not include `Gender` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Gender")]
        public AttributeItem Gender{ get; set; }

        /// <summary>
        /// Hair information, including length, bang, and color. 
        /// If `FaceAttributesType` does not include `Hair` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Hair")]
        public Hair Hair{ get; set; }

        /// <summary>
        /// Hat information, including whether a hat is worn, hat style, and hat color. 
        /// If `FaceAttributesType` does not include `Hat` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Hat")]
        public Hat Hat{ get; set; }

        /// <summary>
        /// Pose information, including the face pitch, yaw, and roll. 
        /// If `FaceAttributesType` does not include `Headpose` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("HeadPose")]
        public HeadPose HeadPose{ get; set; }

        /// <summary>
        /// Mask information. 
        /// The `Type` values of the `AttributeItem` include: 0: no mask; 1: the mask is worn and does not cover the face; 2: the mask is worn and covers the chin; 3: the mask is worn and covers the mouth; 4: the mask is worn properly.
        /// If `FaceAttributesType` does not include `Mask` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Mask")]
        public AttributeItem Mask{ get; set; }

        /// <summary>
        /// Mouth information, including whether the mouth is open and the lip thickness. 
        /// If `FaceAttributesType` does not include `Mouth` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Mouth")]
        public Mouth Mouth{ get; set; }

        /// <summary>
        /// Beard information.
        /// The `Type` values of the `AttributeItem` include: 0: no beard; 1: beard detected. 
        /// If `FaceAttributesType` does not include `Moustache` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Moustache")]
        public AttributeItem Moustache{ get; set; }

        /// <summary>
        /// Nose information. 
        /// The `Type` values of the `AttributeItem` include: 0: upturned nose; 1: aquiline nose; 2: general nose; 3: bulbous nose.
        /// If `FaceAttributesType` does not include `Nose` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Nose")]
        public AttributeItem Nose{ get; set; }

        /// <summary>
        /// Face shape information. 
        /// The `Type` values of the `AttributeItem` include: 0: square; 1: triangular; 2: oval; 3: heart-shaped; 4: round.
        /// If `FaceAttributesType` does not include `Shape` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Shape")]
        public AttributeItem Shape{ get; set; }

        /// <summary>
        /// Skin color information. 
        /// The `Type` values of the `AttributeItem` include: 0: yellow; 1: brown; 2: black; 3: white.
        /// If `FaceAttributesType` does not include `Skin` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Skin")]
        public AttributeItem Skin{ get; set; }

        /// <summary>
        /// Smile level. Value range: [0,100]. 
        /// If `FaceAttributesType` does not include `Smile` or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Smile")]
        public long? Smile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Beauty", this.Beauty);
            this.SetParamObj(map, prefix + "Emotion.", this.Emotion);
            this.SetParamObj(map, prefix + "Eye.", this.Eye);
            this.SetParamObj(map, prefix + "Eyebrow.", this.Eyebrow);
            this.SetParamObj(map, prefix + "Gender.", this.Gender);
            this.SetParamObj(map, prefix + "Hair.", this.Hair);
            this.SetParamObj(map, prefix + "Hat.", this.Hat);
            this.SetParamObj(map, prefix + "HeadPose.", this.HeadPose);
            this.SetParamObj(map, prefix + "Mask.", this.Mask);
            this.SetParamObj(map, prefix + "Mouth.", this.Mouth);
            this.SetParamObj(map, prefix + "Moustache.", this.Moustache);
            this.SetParamObj(map, prefix + "Nose.", this.Nose);
            this.SetParamObj(map, prefix + "Shape.", this.Shape);
            this.SetParamObj(map, prefix + "Skin.", this.Skin);
            this.SetParamSimple(map, prefix + "Smile", this.Smile);
        }
    }
}

