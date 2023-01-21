from pydantic import BaseModel, Field

# ユーザ登録時に必要な型
class UserCreate(BaseModel):
    email: str 
    password: str = Field(max_length=12)
    
# ユーザ作成時に受け取る型
class User(UserCreate):
    user_id: int

    class Config:
        orm_mode = True