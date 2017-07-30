[
    {
        "name": "Rich text editor",
        "alias": "rte",
        "view": "rte",
        "icon": "icon-article"
    },
    {
        "name": "Image",
        "alias": "media",
        "view": "media",
        "icon": "icon-picture"
    },
    {
        "name": "Macro",
        "alias": "macro",
        "view": "macro",
        "icon": "icon-settings-alt"
    },
    {
        "name": "Embed",
        "alias": "embed",
        "view": "embed",
        "icon": "icon-movie-alt"
    },
    {
        "name": "Headline",
        "alias": "headline",
        "view": "textstring",
        "icon": "icon-coin",
        "config": {
            "style": "font-size: 36px; line-height: 45px; font-weight: bold",
            "markup": "<h1>#value#</h1>"
        }
    },
    {
        "name": "Carousel",
        "alias": "carousel",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-picture color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Karousel",
                    "alias": "carousel",
                    "propretyType": {},
                    "dataType": "5d9998f2-4355-4141-9457-ad6df51c8ea7"
                }
            ],
            "expiration": 3600,
            "frontView": ""
        }
    },
    {
        "name": "Factbox",
        "alias": "factbox",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-presentation color-blue",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Content",
                    "alias": "rte",
                    "propretyType": {},
                    "dataType": "3e091be8-a6d8-4db2-930b-99add0475f77"
                }
            ],
            "renderInGrid": "0",
            "expiration": null,
            "frontView": ""
        }
    },
    {
        "name": "Banner",
        "alias": "banner",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-bookmark color-blue",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Baggrundsbillede",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "93929b9a-93a2-4e2a-b239-d99334440a59"
                },
                {
                    "name": "Rubrik",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Underrubrik",
                    "alias": "lead",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                },
                {
                    "name": "Link",
                    "alias": "link",
                    "propretyType": {},
                    "dataType": "4e1aa3a9-c2f7-4423-9086-c48253554b2d"
                }
            ],
            "frontView": "",
            "renderInGrid": "1"
        }
    },
    {
        "name": "Spot",
        "alias": "spot",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-lightbulb-active color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Billede",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "93929b9a-93a2-4e2a-b239-d99334440a59"
                },
                {
                    "name": "Trumpet",
                    "alias": "trumpet",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Rubrik",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Link",
                    "alias": "link",
                    "propretyType": {},
                    "dataType": "4e1aa3a9-c2f7-4423-9086-c48253554b2d"
                },
                {
                    "name": "Tekst",
                    "alias": "content",
                    "propretyType": {},
                    "dataType": "54f514ae-137c-4647-a609-234450b8edf5"
                }
            ],
            "frontView": "",
            "renderInGrid": "1"
        }
    },
    {
        "name": "Counter",
        "alias": "counter",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-coin color-red",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "frontView": "",
            "editors": [
                {
                    "name": "Counter",
                    "alias": "counter",
                    "propretyType": {},
                    "dataType": "ae29284a-5c18-4a83-86e9-b50e46200f40"
                }
            ]
        }
    },
    {
        "name": "Image",
        "alias": "image",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-picture color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Billede",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "93929b9a-93a2-4e2a-b239-d99334440a59"
                },
                {
                    "name": "Billedtekst",
                    "alias": "imageText",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                }
            ],
            "renderInGrid": "0",
            "frontView": ""
        }
    },
    {
        "name": "Gallery",
        "alias": "gallery",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-pictures-alt-2 color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Billeder",
                    "alias": "images",
                    "propretyType": {},
                    "dataType": "7e3962cc-ce20-4ffc-b661-5897a894ba7e"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "List View",
        "alias": "list",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-thumbnail-list color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Pick Pages",
                    "alias": "contentPicker",
                    "propretyType": {},
                    "dataType": "9e2cf629-4a89-4971-8688-8011562e896a",
                    "description": "Picked pages will be rendered as a list."
                }
            ],
            "frontView": "",
            "renderInGrid": "0"
        }
    },
    {
        "name": "Employee List",
        "alias": "employeeList",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-users color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Pick Employees",
                    "alias": "employeePicker",
                    "propretyType": {},
                    "dataType": "cf122230-f075-4fff-a952-5605f1b03659",
                    "description": "Choosen employees will be shown as a list."
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Inject Html",
        "alias": "injectHtml",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-script-alt color-red",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Html",
                    "alias": "html",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Quote",
        "alias": "quote",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-quote",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Quote",
                    "alias": "quote",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                },
                {
                    "name": "Byline",
                    "alias": "byline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Product List",
        "alias": "productList",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-briefcase color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Choose Product Pages",
                    "alias": "contentPicker",
                    "propretyType": {},
                    "dataType": "a12cce5b-73b9-4eb5-a789-bad70d1c8f85"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Pick Employee",
        "alias": "employee",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-umb-users color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Pick Employee",
                    "alias": "contentPicker",
                    "propretyType": {},
                    "dataType": "bb329145-266f-4914-ab10-510db1f804fd"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Teaser Text",
        "alias": "teaserText",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-article color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Lead",
                    "alias": "lead",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Cover Image",
        "alias": "CoverImage",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-umb-media color-green",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Image",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "93929b9a-93a2-4e2a-b239-d99334440a59"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Teaser Image",
        "alias": "teaserImage",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-umb-media color-blue",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Image",
                    "alias": "image",
                    "propretyType": {},
                    "dataType": "93929b9a-93a2-4e2a-b239-d99334440a59"
                }
            ],
            "frontView": "",
            "expiration": 3600
        }
    },
    {
        "name": "Random Cover Image",
        "alias": "randomCoverImage",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-pictures-alt-2 color-red",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "frontView": "",
            "editors": [
                {
                    "name": "Text",
                    "alias": "text",
                    "propretyType": {},
                    "dataType": "c6bac0dd-4ab9-45b1-8e30-e4b619ee5da3",
                    "description": "Text will be shown as a speech bubble for the random image."
                },
                {
                    "name": "Images",
                    "alias": "images",
                    "propretyType": {},
                    "dataType": "7e3962cc-ce20-4ffc-b661-5897a894ba7e",
                    "description": "One image will be randomly choosen and shown as a cover image."
                },
                {
                    "name": "Link",
                    "alias": "link",
                    "propretyType": {},
                    "dataType": "4e1aa3a9-c2f7-4423-9086-c48253554b2d"
                }
            ]
        }
    },
    {
        "name": "Case Teaser",
        "alias": "caseTeaser",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-utilities color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Pick Case",
                    "alias": "contentPicker",
                    "propretyType": {},
                    "dataType": "308a0ad9-5b29-4872-850e-f7635f527428"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "Link List",
        "alias": "linkList",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-link color-red",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "Heading",
                    "alias": "headline",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "Links",
                    "alias": "links",
                    "propretyType": {},
                    "dataType": "20aff2fb-5600-4cd2-8243-bf77a8c05172"
                }
            ],
            "frontView": ""
        }
    }
]